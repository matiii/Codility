namespace Codility.BracketsRotation
{
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using System.Threading.Tasks;

    class SolutionParallel : IDisposable
    {
        private const char Right = ')';

        private readonly BlockingCollection<T> _que = new BlockingCollection<T>(new ConcurrentBag<T>());
        private readonly ManualResetEventSlim _swapLock = new ManualResetEventSlim(true);

        private int _currentTasks = 0;

        private volatile int _iterator = 0;
        private volatile int _result = 0;

        private int _completeChecker = 0;

        private int _sLength;
        private int _k;

        private void CompleteIfCan()
        {
            if (Interlocked.CompareExchange(ref _currentTasks, 0, 0) == 0 && Interlocked.Exchange(ref _completeChecker, 1) == 0)
            {
                _iterator++;

                if (_result >= _sLength - _iterator || _iterator == _sLength)
                    _que.CompleteAdding();
                else
                {
                    var t = new T {Key = _iterator, Counter = 0, Length = 0, K = _k};
                    Enqueue(ref t);
                }

                Interlocked.Exchange(ref _completeChecker, 0);
            }
        }

        private void ExchangeResult(int length)
        {
            _swapLock.Wait();
            _swapLock.Reset();
            if (length > _result)
                _result = length;

            _swapLock.Set();
        }

        private bool Enqueue(ref T n)
        {
            if (n.Key < _sLength)
            {
                Interlocked.Increment(ref _currentTasks);
                _que.Add(n);
                return true;
            }

            return false;
        }

        public int solution(string S, int K)
        {
            _sLength = S.Length;
            _k = K;

            var first = new T {Key = 0, Counter = 0, Length = 0, K = K};

            if (!Enqueue(ref first))
                _que.CompleteAdding();

            foreach (T t in _que.GetConsumingEnumerable())
            {
                T n = t;

                Task.Factory.StartNew(() =>
                {
                    if (S[n.Key] == Right)
                        n.Counter--;
                    else
                        n.Counter++;

                    if (n.Counter == 0)
                    {
                        n.Length++;
                        n.Key++;

                        ExchangeResult(n.Length);
                        Enqueue(ref n);
                    }
                    else if (n.Counter == -1 && n.K > 0)
                    {
                        n.Counter += 2;
                        n.K--;
                        n.Length++;
                        n.Key++;

                        Enqueue(ref n);
                    }
                    else if (n.Counter > 0)
                    {
                        if (n.Counter < S.Length - n.Key)
                        {
                            var next = new T { Counter = n.Counter, K = n.K, Key = n.Key + 1, Length = n.Length + 1 };
                            Enqueue(ref next);
                        }

                        if (n.Counter == 2 && n.K > 0)
                        {
                            n.Counter -= 2;
                            n.K--;
                            n.Length++;
                            n.Key++;

                            ExchangeResult(n.Length);

                            Enqueue(ref n);
                        }
                    }

                    Interlocked.Decrement(ref _currentTasks);
                    CompleteIfCan();
                });
            }

            return _result;
        }

        private struct T
        {
            public int Key { get; set; }
            public int Counter { get; set; }
            public int K { get; set; }
            public int Length { get; set; }
        }

        public void Dispose()
        {
            _swapLock.Dispose();
        }
    }
}

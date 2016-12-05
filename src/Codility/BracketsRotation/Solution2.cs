namespace Codility.BracketsRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Solution2
    {
        private const char Right = ')';

        public int solution(string S, int K)
        {
            var q = new Queue<T>();
            int result = 0;

            Func<int, int, int> max = (a, b) => a > b ? a : b;

            Action<T, int> checkResult = (t,i) =>
            {
                t.Stack.Pop();

                if (t.Stack.Count > 0)
                    result = max(result, i - t.Stack.Peek());
                else
                    t.Stack.Push(i);
            };

            q.Enqueue(new T {I = 0, K = K });

            while (q.Count > 0)
            {
                T t = q.Dequeue();

                for (int i = t.I; i < S.Length; i++)
                {
                    if (S[i] == Right)
                    {
                        if (t.K > 0)
                        {
                            T t1 = t.Clone();
                            t1.K--;
                            t1.Stack.Push(i);
                            t1.I = i + 1;
                            q.Enqueue(t1);
                        }

                        checkResult(t, i);
                    }
                    else
                    {
                        if (t.K > 0)
                        {
                            T t1 = t.Clone();
                            t1.K--;
                            checkResult(t1, i);
                            t1.I = i + 1;
                            q.Enqueue(t1);
                        }

                        t.Stack.Push(i);
                    }
                }
            }

            return result;
        }

        private class T
        {
            public int I { get; set; }
            public int K { get; set; }
            public Stack<int> Stack { get; private set; } = new Stack<int>(new[] { -1 });
            public T Clone()
            {
                var t = new T {K = K, I = I, Stack = new Stack<int>(Stack.Count)};

                foreach (var e in Stack.Reverse())
                    t.Stack.Push(e);

                return t;
            }
        }
    }
}

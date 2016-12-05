namespace Codility.BracketsRotation
{
    using System;
    using System.Collections.Generic;

    class Solution6
    {
        private const char Open = '(';
        private const char Close = ')';

        public int solution(string S, int K)
        {
            int result = 0;

            var q = new Queue<T>(S.Length);
            var add = new HashSet<int>();

            q.Enqueue(new T(0, S.Length));

            while (q.Count > 0)
            {
                T t = q.Dequeue();

                int length = t.To - t.From;

                if (length % 2 != 0)
                {
                    q.Enqueue(new T(t.From + 1, t.To));
                    q.Enqueue(new T(t.From, t.To - 1));
                    continue;
                }

                Result res = MinReversals(t.From, t.To, S);

                if (K >= res.Number)
                    return length;

                int diff = res.Number - K;

                length -= diff;
                if (length % 2 != 0)
                {
                    length--;
                }


                if (add.Contains(length))
                    continue;

                add.Add(length);

                int longest = res.To - res.From;

                int d = length - longest;

                int i = res.From - d;

                if (i < 0)
                    i = 0;

                while (true)
                {
                    var n = new T(i, i+length);
                    if (n.To > S.Length)
                        break;
                    i++;
                    q.Enqueue(n);
                }

            }

            return result;
        }

        private struct T
        {
            public T(int @from, int to)
            {
                From = @from;
                To = to;
            }

            public int From { get; }
            public int To { get; }
        }

        private struct Result
        {
            public Result(int number, int @from, int to)
            {
                Number = number;
                From = @from;
                To = to;
            }

            public int Number { get; }
            public int From { get; }
            public int To { get; }
        }

        private Result MinReversals(int from, int to, string s)
        {
            var stack = new Stack<char>();
            var stk = new Stack<int>();
            stk.Push(-1);

            int result = 0;

            int f = 0;
            int t = 0;

            Func<int, int, int, int> max = (prev, index, peek) =>
            {
                int lng = index - peek;
                if (lng > prev)
                {
                    f = peek;
                    t = index;
                    return lng;
                }

                return prev;
            };

            for (int i = from; i < to; i++)
            {
                if (s[i] == Open)
                    stk.Push(i);
                else
                {
                    stk.Pop();

                    if (stk.Count > 0)
                        result = max(result, i, stk.Peek());
                    else
                        stk.Push(i);
                }

                if (s[i] == Close && stack.Count > 0)
                {
                    if (stack.Peek() == Open)
                        stack.Pop();
                    else
                        stack.Push(s[i]);
                }
                else
                    stack.Push(s[i]);
            }

            int redLen = stack.Count;
            int n = 0;

            while (stack.Count > 0 && stack.Peek() == Open)
            {
                stack.Pop();
                n++;
            }

            int number = redLen/2 + n%2;

            return new Result(number, f, t);
        }
    }
}

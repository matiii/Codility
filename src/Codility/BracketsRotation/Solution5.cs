﻿namespace Codility.BracketsRotation
{
    using System.Collections.Generic;

    class Solution5
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

                int minRev = MinReversals(t.From, t.To, S);

                if (K >= minRev)
                    return length;

                int diff = minRev - K;

                length -= diff;
                if (length % 2 != 0)
                {
                    length--;
                }

                if (add.Contains(length))
                    continue;

                add.Add(length);

                int i = 0;

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

        private int MinReversals(int from, int to, string s)
        {
            var stack = new Stack<char>();

            for (int i = from; i < to; i++)
            {
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

            return number;
        }
    }
}

namespace Codility.BracketsRotation
{
    using System.Collections.Generic;
    using System.Linq;

    class Solution4
    {
        private const char Open = '(';
        private const char Close = ')';

        public int solution(string S, int K)
        {
            int result = 0;

            var q = new SortedSet<T>(new TComparer());

            q.Add(new T(0, S.Length));

            while (q.Count > 0)
            {
                T t = q.First();
                q.Remove(t);
                
                int length = t.To - t.From;

                if (length%2!= 0)
                {
                    q.Add(new T(t.From + 1, t.To));
                    q.Add(new T(t.From, t.To - 1));
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

                int i = t.From;

                while (true)
                {
                    var n = new T(i, i+length);
                    if (n.To > t.To)
                        break;
                    i++;
                    q.Add(n);
                }

            }

            return result;
        }

        private class TComparer: IComparer<T>
        {
            public int Compare(T x, T y)
            {
                if (x.To == y.To && x.From == y.From)
                    return 0;

                int xLength = x.To - x.From;
                int yLength = y.To - y.From;

                if (xLength == yLength)
                    return x.To.CompareTo(y.To);

                return -xLength.CompareTo(yLength);
            }
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

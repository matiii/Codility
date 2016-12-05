namespace Codility.BracketsRotation
{
    using System;
    using System.Collections.Generic;

    class Solution7
    {
        private const char Open = '(';
        private const char Close = ')';

        public int solution(string S, int K)
        {
            int result = 0;

            var stack = new Stack<KeyValuePair<int, char>>();
            var stk = new Stack<int>();
            stk.Push(-1);

            int m = 0;

            int from = 0;
            int to = 0;
            bool one = false;

            Func<int, int, bool> isOne = (f, t) =>
            {
                int i = 0;
                char first = '\0';
                char second = '\0';

                if (f-1 >= 0)
                {
                    first = S[f - 1];
                    i++;
                }

                if (f >= 0)
                {
                    if (i > 0)
                    {
                        second = S[f];
                    }
                    else
                    {
                        first = S[f];
                    }

                    i++;
                }

                if (t+1 < S.Length && i < 2)
                {
                    if (i > 0)
                    {
                        second = S[t + 1];
                    }
                    else
                    {
                        first = S[t + 1];
                    }

                    i++;
                }

                if (t+2 < S.Length && i == 1)
                {
                    second = S[t + 2];
                }

                return first == second;
            };

            Func<int, int, int, int> max = (prev, i, peek) =>
            {
                int l = i - peek;
                
                if (l> prev || l == prev && !one)
                {
                    from = peek;
                    to = i;
                    one = isOne(from, to);
                    return l;
                }

                return prev;
            };

            int start = 0, sLength = S.Length;

            if (S.Length%2 != 0)
            {
                if (S[start] == Close)
                    start++;
                else
                    sLength--;
            }

            for (int i = start, j = 0; j < S.Length; i++, j++)
            {
                if (S[j] == Open)
                    stk.Push(j);
                else
                {
                    stk.Pop();

                    if (stk.Count > 0)
                        m = max(m, j,stk.Peek());
                    else
                        stk.Push(j);
                }

                if (i == sLength)
                    continue;
                
                if (S[i] == Close && stack.Count > 0)
                {
                    if (stack.Peek().Value == Open)
                        stack.Pop();
                    else
                        stack.Push(new KeyValuePair<int, char>(i, S[i]));
                }
                else
                    stack.Push(new KeyValuePair<int, char>(i, S[i]));
            }

            int redLen = stack.Count;

            int n = 0;

            while (stack.Count > 0 && stack.Peek().Value == Open)
            {
                stack.Pop();
                n++;
            }

            int number = redLen/2 + n%2;

            if (K >= number)
                result = S.Length;
            else
            {
                int t = (number - redLen/2)*2;
                int t2 = number - t;

                if (K == 1)
                {
                    result = m + (one ? 2 : 0);
                }
                else if (K >= t2)
                    result = m + t2*2 + (K-t2)/2;
                else
                {
                    t2 = K;
                    result = m + t2*2;
                }
            }

            if (result%2 != 0)
                result--;

            return result;
        }
    }
}

namespace Codility.BracketsRotation
{
    using System.Collections.Generic;

    class Solution
    {
        private const char Right = ')';

        public int solution(string S, int K)
        {
            int result = 0;
            var q = new Queue<T>();

            for (int i = 0; i < S.Length; i++)
            {
                if (result >= S.Length - i)
                    break;

                q.Enqueue(new T { Key = i, Counter = 0, Length = 0, K = K });

                while (q.Count > 0)
                {
                    T n = q.Dequeue();

                    if (S[n.Key] == Right)
                        n.Counter--;
                    else
                        n.Counter++;

                    if (n.Counter == 0)
                    {
                        n.Length++;
                        n.Key++;

                        if (n.Length > result)
                            result = n.Length;

                        if (n.Key < S.Length)
                            q.Enqueue(n);
                    }
                    else if (n.Counter == -1 && n.K > 0)
                    {
                        n.Counter += 2;
                        n.K--;
                        n.Length++;
                        n.Key++;

                        if (n.Key < S.Length)
                            q.Enqueue(n);
                    }
                    else if (n.Counter > 0)
                    {
                        if (n.Counter < S.Length - n.Key)
                            q.Enqueue(new T { Counter = n.Counter, K = n.K, Key = n.Key + 1, Length = n.Length + 1 });

                        if (n.Counter == 2 && n.K > 0)
                        {
                            n.Counter -= 2;
                            n.K--;
                            n.Length++;
                            n.Key++;

                            if (n.Length > result)
                                result = n.Length;

                            if (n.Key < S.Length)
                                q.Enqueue(n);
                        }
                    }
                }
            }

            return result;
        }

        private struct T
        {
            public int Key { get; set; }
            public int Counter { get; set; }
            public int K { get; set; }
            public int Length { get; set; }
        }
    }
}

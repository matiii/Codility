namespace Codility.GenomicRangeQuery
{
    class Solution
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            int[] result = new int[P.Length];

            int[] a = new int[S.Length];
            int[] c = new int[S.Length];
            int[] g = new int[S.Length];

            for (int i = 0; i < S.Length; i++)
            {
                if (i > 0)
                {
                    a[i] = a[i - 1];
                    c[i] = c[i - 1];
                    g[i] = g[i - 1];
                }

                if (S[i] == 'A')
                {
                    a[i]++;
                }
                else if (S[i] == 'C')
                {
                    c[i]++;
                }
                else if (S[i] == 'G')
                {
                    g[i]++;
                }
            }

            for (int i = 0; i < P.Length; i++)
            {
                int from = P[i];
                int to = Q[i];

                if (from == 0 && a[from] == 1 || from > 0 && a[from-1] != a[from] || from != to && a[from] != a[to] || S[to] == 'A')
                {
                    result[i] = 1;
                }
                else if (from == 0 && c[from] == 1 || from > 0 && c[from - 1] != c[from] || from != to && c[from] != c[to] || S[to] == 'C')
                {
                    result[i] = 2;
                }
                else if (from == 0 && g[from] == 1 || from > 0 && g[from - 1] != g[from] || from != to && g[from] != g[to] || S[to] == 'G')
                {
                    result[i] = 3;
                }
                else
                {
                    result[i] = 4;
                }
            }

            return result;
        }

    }
}

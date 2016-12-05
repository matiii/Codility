namespace Codility.Nails
{
    class Solution
    {
        public int solution(int[] A, int K)
        {
            int n = A.Length;
            int best = 0;
            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (A[i] == A[i + 1])
                    count = count + 1;
                else
                    count = 0;
                if (count + (K > n - i - 2 ? n - i - 2 : K) > best)
                    best = count + (K > n - i - 2 ? n - i - 2 : K);
            }
            int result = best+1;

            return result;
        }
    }
}

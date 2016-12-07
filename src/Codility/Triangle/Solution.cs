namespace Codility.Triangle
{
    using System;

    class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            for (int i = 0; i < A.Length-2; i++)
            {
                long p = A[i];
                long q = A[i + 1];
                long r = A[i + 2];

                if (p + q > r)
                    return 1;
            }

            return 0;
        }
    }
}

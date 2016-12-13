namespace Codility.MaxSliceSum
{
    using System;

    class Solution
    {
        public int solution(int[] A)
        {
            var x = new int[A.Length];
            x[0] = A[0];
            int max = x[0];

            for (int i = 1; i < A.Length; i++)
            {
                int sum = Math.Max(x[i - 1], 0) + A[i];
                x[i] = sum;

                if (sum > max)
                    max = sum;
            }

            return max;
        }
    }
}

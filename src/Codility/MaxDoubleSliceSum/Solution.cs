namespace Codility.MaxDoubleSliceSum
{
    using System;

    class Solution
    {
        public int solution(int[] A)
        {
            var x = new int[A.Length];
            var y = new int[A.Length];

            int max = 0;

            for (int i = 1; i < A.Length-1; i++)
            {
                x[i] = Math.Max(0, x[i - 1] + A[i]);
                y[y.Length - i - 1] = Math.Max(0, y[y.Length - i] + A[A.Length - i - 1]);
            }

            for (int i = 0; i < x.Length-2; i++)
            {
                int sum = x[i] + y[i + 2];

                if (sum > max)
                    max = sum;
            }

            return max;
        }
    }
}

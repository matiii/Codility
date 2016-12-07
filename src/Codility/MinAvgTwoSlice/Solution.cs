namespace Codility.MinAvgTwoSlice
{
    using System;

    class Solution
    {
        public int solution(int[] A)
        {
            int index = 0;
            double min = Double.MaxValue;

            for (int i = 0; i < A.Length - 1; i++)
            {
                double sum = (A[i] + A[i+1])/2.0;

                if (sum < min)
                {
                    min = sum;
                    index = i;
                }

                if (i == 0)
                    continue;

                double sum2 = (A[i-1]+A[i]+A[i+1])/3.0;

                if (sum2 < min && sum2 < sum)
                {
                    min = sum2;
                    index = i - 1;
                }
            }

            return index;
        }
    }
}

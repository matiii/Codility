namespace Codility.TapeEquilibrium
{
    using System;
    using System.Linq;

    public class Solution
    {
        public int solution(int[] A)
        {
            int[] s = new int[A.Length];
            s[0] = A[0];

            int sum = A.Sum();
            int min = Int32.MaxValue;

            for (int i = 1; i < A.Length; i++)
            {
                s[i] = s[i - 1] + A[i];
                int diff = Math.Abs(2*s[i - 1] - sum);
                if (min > diff)
                {
                    min = diff;
                }
            }

            return min;
        }
    }
}

namespace Codility.CountFactors
{
    using System;

    class Solution
    {
        public int solution(int N)
        {
            int result = N > 1 ? 2 : 1;
            double sqrt = Math.Sqrt(N);

            for (int i = 2; i <= sqrt; i++)
            {
                if (N%i == 0)
                {
                    result+=2;

                    if (sqrt == i)
                        result--;
                }
            }

            return result;
        }
    }
}

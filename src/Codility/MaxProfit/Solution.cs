namespace Codility.MaxProfit
{
    using System;

    class Solution
    {
        public int solution(int[] A)
        {
            int min = Int32.MaxValue;
            int profit = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int price = A[i];

                if (price < min)
                    min = price;
                else
                {
                    int newProfit = price - min;

                    if (newProfit > profit)
                        profit = newProfit;
                }
            }

            return profit > 0 ? profit : 0;
        }
    }
}

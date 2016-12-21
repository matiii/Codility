namespace Codility.MinPerimeterRectangle
{
    using System;

    class Solution
    {
        public int solution(int N)
        {
            double sqrt = Math.Sqrt(N);
            int result = Int32.MaxValue;

            for (int i = 1; i <= sqrt; i++)
            {
                if (N%i == 0)
                {
                    int perimeter = 2*(i + N/i);

                    if (perimeter < result)
                        result = perimeter;
                }
            }

            return result;
        }
    }
}

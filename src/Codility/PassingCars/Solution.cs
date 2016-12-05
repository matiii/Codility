namespace Codility.PassingCars
{
    class Solution
    {
        public int solution(int[] A)
        {
            const int max = 1000000000;
            int result = 0;
            int p = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                    p++;
                else
                    result += p;

                if (result > max)
                    return -1;
            }

            return result;
        }
    }
}

namespace Codility.OddOccurrencesInArray
{
    class Solution
    {
        public int solution(int[] A)
        {
            int result = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                result ^= A[i];
            }

            return result;
        }
    }
}

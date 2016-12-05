namespace Codility.PermMissingElem
{
    class Solution
    {
        public int solution(int[] A)
        {
            int result = 0;
            int sum = 0;

            for (int i = 0; i <= A.Length; i++)
            {
                if (i != A.Length)
                    result += A[i];
                sum += i+1;
            }

            return sum - result;
        }
    }
}

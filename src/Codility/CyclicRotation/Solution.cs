namespace Codility.CyclicRotation
{
    class Solution
    {
        public int[] solution(int[] A, int K)
        {
            int[] res = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                int next = (i + K)%A.Length;
                res[next] = A[i];
            }

            return res;
        }
    }
}

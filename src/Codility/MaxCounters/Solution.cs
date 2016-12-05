namespace Codility.MaxCounters
{
    class Solution
    {
        public int[] solution(int N, int[] A)
        {
            int[] result = new int[N];
            int max = 0;
            int last = -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == N + 1)
                {
                    if (last != max)
                    {
                        for (int j = 0; j < N; j++)
                            result[j] = max;

                        last = max;
                    }
                }
                else
                {
                    int index = A[i] - 1;
                    result[index] += 1;

                    if (result[index] > max)
                        max = result[index];
                }
            }

            return result;
        }
    }
}

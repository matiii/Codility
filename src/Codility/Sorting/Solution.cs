namespace Codility.Sorting
{
    class Solution
    {
        public int solution(int[] A)
        {
            int result = 0;
            int counter = 0;
            int max = -1;

            bool isGreater = false;

            for (int i = 0; i < A.Length - 1; i++)
            {
                int first = A[i];
                int second = A[i+1];

                if (first > second || isGreater && max>first)
                {
                    result++;
                    result += counter;
                    isGreater = true;
                    counter = 0;

                    if (first > max)
                        max = first;

                    if (i == A.Length - 2 && second < max)
                        result++;
                }
                else if (isGreater)
                    counter++;
            }

            return result;
        }
    }
}

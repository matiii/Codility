namespace Codility.Dominator
{
    using System.Collections.Generic;

    class Solution
    {
        public int solution(int[] A)
        {
            var dict = new Dictionary<int, int>();
            int max = A.Length/2;

            for (int i = 0; i < A.Length; i++)
            {
                int number = A[i];

                if (dict.ContainsKey(number))
                    dict[number]++;
                else
                    dict[number] = 1;

                if (dict[number] > max)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

namespace Codility.EquiLeader
{
    using System.Collections.Generic;

    class Solution
    {
        public int solution(int[] A)
        {
            var dict = new Dictionary<int, int>();
            int max = A.Length/2;
            int? key = null;

            for (int i = 0; i < A.Length; i++)
            {
                int number = A[i];

                if (dict.ContainsKey(number))
                    dict[number]++;
                else
                    dict[number] = 1;

                if (dict[number] > max)
                    key = number;
            }

            if (!key.HasValue)
                return 0;

            int result = 0;
            int n = key.Value;
            int count = dict[n];
            int last = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == n)
                    last++;

                bool isLead1 = last > (i+1)/2;
                bool isLead2 = count - last > (A.Length - i-1)/2;

                if (isLead1 && isLead2)
                {
                    result++;
                    if (i == A.Length - 2)
                        i++;
                }
            }

            return result;
        }
    }
}

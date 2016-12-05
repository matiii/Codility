namespace Codility.MissingInteger
{
    using System.Collections.Generic;

    class Solution
    {
        public int solution(int[] A)
        {
            int current = 0;

            var set = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                set.Add(A[i]);

                if (A[i] == current + 1)
                    current++;

                while (set.Contains(current + 1))
                {
                    current++;
                }
            }

            return current+1;
        }
    }
}

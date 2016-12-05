namespace Codility.FrogRiverOne
{
    using System;
    using System.Collections.Generic;

    class Solution
    {
        public int solution(int X, int[] A)
        {
            int current = 0;

            var set = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                set.Add(A[i]);

                if (A[i] == current + 1)
                    current++;

                while (set.Contains(current +1) && current <= X)
                {
                    current++;
                }

                if (current == X)
                    return i;
            }

            return -1;
        }
    }
}

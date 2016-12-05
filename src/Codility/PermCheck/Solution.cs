namespace Codility.PermCheck
{
    using System.Collections.Generic;

    class Solution
    {
        public int solution(int[] A)
        {
            int sum = 0, current = 0;

            var set = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                sum += i + 1;
                current += A[i];
                set.Add(A[i]);
            }

            return sum == current && set.Count == A.Length ? 1 : 0;
        }
    }
}

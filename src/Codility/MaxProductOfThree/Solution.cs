namespace Codility.MaxProductOfThree
{
    using System;

    class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int n = A.Length-1;

            int first = A[0]*A[1];
            int second = A[n - 1]*A[n - 2];

            return A[n] * (first > second && A[n] >= 0 ? first : second);
        }
    }
}

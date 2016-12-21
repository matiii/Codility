namespace Codility.Peaks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Solution
    {
        public int solution(int[] A)
        {
            var peaks = new HashSet<int>();

            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                    peaks.Add(i);
            }

            Func<int,int> getMax = x =>
            {
                int m = x;

                while (m > 0 && A.Length%m != 0)
                    m--;
                
                return m;
            };

            int result = peaks.Count;

            while (true)
            {
                result = getMax(result);

                if (result == 0)
                    break;

                int parts = A.Length/result;

                bool ok = true;

                for (int i = 0; i < A.Length; i+=parts)
                {
                    if (!Enumerable.Range(i, parts).Any(x => peaks.Contains(x)))
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                    break;

                result--;
            }

            return result;
        }
    }
}

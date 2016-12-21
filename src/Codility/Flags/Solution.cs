namespace Codility.Flags
{
    using System;
    using System.Collections.Generic;

    class Solution
    {
        public int solution(int[] A)
        {
            var peaks = new List<int>(A.Length);

            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                    peaks.Add(i);
            }
            

            if (peaks.Count < 3)
                return peaks.Count;

            int max = (int)Math.Sqrt(peaks[peaks.Count-1] - peaks[0]) + 1;

            Func<int, bool> ok = flags =>
            {
                int counter = 1;

                for (int i = 0; i < peaks.Count - 1; i++)
                {
                    int first = peaks[i];

                    while (i+1 < peaks.Count && peaks[i+1] - first < flags)
                    {
                        i++;
                    }

                    if (i+1 < peaks.Count && peaks[i+1] - first >= flags)
                        counter++;

                    if (counter == flags)
                        break;
                }

                return counter == flags;
            };

            while (!ok(max) && max > 0)
                max--;

            return max;
        }
    }
}

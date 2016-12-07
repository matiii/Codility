namespace Codility.NumberOfDiscIntersections
{
    using System.Linq;

    class Solution
    {
        private struct Interval
        {
            public Interval(long @from, long to)
            {
                From = @from;
                To = to;
            }

            public long From { get; }
            public long To { get; }
        }

        public int solution(int[] A)
        {
            int result = 0;

            Interval[] intervals = A.Select((value, i) =>
            {
                long iL = i;
                return new Interval(iL - value, iL + value);
            })
            .OrderBy(x => x.From)
            .ToArray();

            for (int i = 0; i < intervals.Length; i++)
            {
                for (int j = i + 1; j < intervals.Length && intervals[j].From <= intervals[i].To; j++)
                    result++;

                if (result > 10000000)
                    return -1;
            }

            return result;
        }
    }
}

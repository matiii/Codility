namespace Codility.BinaryGap
{
    using System;

    class Solution
    {
        public int solution(int N)
        {
            string s = Convert.ToString(N, 2);
            int max = 0;
            N = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                    N++;
                else
                {
                    max = max > N ? max : N;
                    N = 0;
                }
            }

            return max;
        }
    }
}

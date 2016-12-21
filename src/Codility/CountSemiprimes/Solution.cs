namespace Codility.CountSemiprimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Solution
    {

        public int[] solution(int N, int[] P, int[] Q)
        {
            var primes = new HashSet<int>();
            var other = new HashSet<int>();
            var semiprimes = new List<int>(N/2);

            other.Add(1);

            for (int i = 2; i <= N; i++)
            {
                if (other.Contains(i))
                    continue;

                primes.Add(i);

                for (int j = 2; j * i <= N; j++)
                {
                    int num = i*j;
                    other.Add(num);
                }
            }

            int skip = 0;

            foreach (var prime in primes)
            {
                foreach (var second in primes.Skip(skip))
                {
                    int num = prime*second;

                    if (num > N)
                        break;

                    semiprimes.Add(num);
                }
                skip++;
            }

            var array = semiprimes.ToArray();
            Array.Sort(array);
            var dict = new Dictionary<int,int>(array.Length);

            for (int i = 0; i < array.Length; i++)
                dict.Add(array[i], i);

            var result = new int[P.Length];

            for (int j = 0; j < result.Length; j++)
            {
                int snd = Q[j];
                int fst = P[j];

                while (!dict.ContainsKey(snd) && snd > 0)
                {
                    snd--;
                }

                while (!dict.ContainsKey(fst) && fst < snd)
                {
                    fst++;
                }

                result[j] = snd >= fst && dict.ContainsKey(fst) && dict.ContainsKey(snd) ? dict[snd] - dict[fst] + 1 : 0;
            }


            return result;
        }
    }
}

namespace Codility.Distinct
{
    using System.Linq;

    class Solution
    {
        public int solution(int[] A)
        {
            return A.Distinct().Count();
        }
    }
}

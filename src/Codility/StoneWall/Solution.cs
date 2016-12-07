namespace Codility.StoneWall
{
    using System.Collections.Generic;

    class Solution
    {
        //TODO
        public int solution(int[] H)
        {
            var stack = new Stack<int>();
            int result = 0;

            for (int i = 0; i < H.Length; i++)
            {
                int h = H[i];

                if (stack.Count == 0 || stack.Peek() <= h)
                {
                    stack.Push(h);
                }
                else
                {
                    result++;
                }
            }

            return result;
        }
    }
}

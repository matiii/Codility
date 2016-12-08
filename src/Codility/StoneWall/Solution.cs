namespace Codility.StoneWall
{
    using System.Collections.Generic;

    class Solution
    {
        public int solution(int[] H)
        {
            var stack = new Stack<int>();
            int result = 0;

            for (int i = 0; i < H.Length; i++)
            {
                int h = H[i];

                while (stack.Count > 0 && h < stack.Peek())
                    stack.Pop();

                if (stack.Count > 0 && h == stack.Peek())
                    continue;

                stack.Push(h);
                result++;
            }


            return result;
        }
    }
}

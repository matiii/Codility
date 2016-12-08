namespace Codility.Fish
{
    using System.Collections.Generic;

    class Solution
    {
        //check
        public int solution(int[] A, int[] B)
        {
            var stack = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                int size = A[i];
                int direction = B[i];

                if (stack.Count == 0 || B[stack.Peek()] == direction)
                {
                    stack.Push(i);
                }
                else
                {
                    int prev = stack.Pop();

                    if (A[prev] > size)
                        stack.Push(prev);
                    else
                        stack.Push(i);
                }
            }

            return stack.Count;
        }
    }
}

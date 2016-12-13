namespace Codility.Fish
{
    using System.Collections.Generic;

    class Solution
    {
        public int solution(int[] A, int[] B)
        {
            var stack = new Stack<int>();
            stack.Push(0);

            for (int i = 1; i < A.Length; i++)
            {
                int direction = B[stack.Peek()];
                stack.Push(i);

                while (stack.Count > 1 && (direction != 0 || B[stack.Peek()] != 1) && B[stack.Peek()] != direction)
                {
                    int front = stack.Pop();
                    int behind = stack.Pop();

                    if (stack.Count > 0)
                        direction = B[stack.Peek()];

                    if (A[front] > A[behind])
                        stack.Push(front);
                    else
                        stack.Push(behind);
                }

            }

            return stack.Count;
        }
    }
}

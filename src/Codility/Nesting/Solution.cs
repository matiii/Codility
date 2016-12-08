namespace Codility.Nesting
{
    using System.Collections.Generic;

    class Solution
    {
        public int solution(string S)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                char c = S[i];

                if (c == '(')
                    stack.Push(c);
                else if (stack.Count > 0)
                    stack.Pop();
                else
                    return 0;
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}

namespace Codility.Brackets
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

                if (c == '(' || c == '{' || c == '[')
                    stack.Push(c);
                else if (stack.Count > 0)
                {
                    char r = stack.Pop();

                    if (c == ')' && r != '(')
                        return 0;

                    if (c == '}' && r != '{')
                        return 0;

                    if (c == ']' && r != '[')
                        return 0;
                }
                else
                    return 0;
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}

 
namespace IRISTest
{
    public class Task2
    {
        /// <summary>
        /// Methode to check given expression have balanced Parentheses
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static bool AreParenthesesBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>(); 
            foreach (char ch in expression)
            {
                switch (ch)
                {
                    case '(': 
                        stack.Push(ch); // Push opening brackets onto the stack
                        break;

                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(') // Check matching opening bracket
                            return false;
                        break; 
                }
            }

            // If stack is empty, all opening brackets had matching closing brackets
            return stack.Count == 0;
        }
    }
}

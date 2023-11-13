using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAndStacks.Classes
{
    public static class Problems
    {
        public static bool AreBracketsValid(string expression)
        {
            StaticStack<char> bracketStack = new (expression.Length);  
            foreach (char item in expression)
            {
                if (item == '(')
                {
                    bracketStack.Push(item);
                }
                else if (item == ')')
                {
                    if (bracketStack.IsEmpty())
                    {
                        return false; // There is a close bracket but no corresponding opening bracket                        
                    }
                    bracketStack.Pop();

                }
            }
            return bracketStack.IsEmpty(); // At the end the stack should be empty if the brackets match
        }

        public static List<T> ReverseStack<T>(StaticStack<T> stack)
        {
            List<T> result = new ();
            StaticQueue<T> queue = new StaticQueue<T>(stack.Capacity);
            while (!stack.IsEmpty())
            {
                queue.EnQueue(stack.Pop());
            }
            while (!queue.IsEmpty())
            {
                result.Add(queue.DeQueue());    
            }
            return result;
        }
    }
}

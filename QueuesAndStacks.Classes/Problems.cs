using System;
using System.Collections;
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

        public static void ReverseStack<T>(StaticStack<T> stack)
        {
            StaticQueue<T> queue = new StaticQueue<T>(stack.Capacity);
            while (!stack.IsEmpty())
            {
                queue.EnQueue(stack.Pop()); // Pop all stack items and enqueue them
            }
            while (!queue.IsEmpty())
            {
                stack.Push(queue.DeQueue()); // Dequeue the queue items and push them on to the stack
            }
        }

        public static List<string> WriteBinary(int n)
        {
            List<string> result = new();
            StaticQueue<string> queue = new(n+1);
            queue.EnQueue("1");
            for (int i = 1; i <= n; i++)
            {
                string value = queue.DeQueue();
                result.Add(value);
                queue.EnQueue(value + "0");
                queue.EnQueue(value + "1");
            }
            return result;
        }
    }
}

using System;
using QueuesAndStacks.Classes;

namespace QueuesAndStacks
{
    internal class Program
    {
        static void Main()
        {
            StringQueue();
            // NumberQueue();
            //StudentStack();
        }

        private static void StringQueue()
        {
            StaticQueue<string> colours = new StaticQueue<string>(10);
            colours.EnQueue("red");
            colours.EnQueue("green");
            colours.EnQueue("yellow");
            Console.WriteLine($"colours in queue: {colours.Display()}");
            Console.WriteLine($"colour removed: {colours.DeQueue() ?? "List Empty"}");
            colours.EnQueue("purple");
            Console.WriteLine($"colours in queue: {colours.Display()}");
            Console.WriteLine($"colour removed: {colours.DeQueue() ?? "List Empty"}");
            Console.WriteLine($"colours in queue: {colours.Display()}");
            Console.WriteLine($"colour removed: {colours.DeQueue() ?? "List Empty"}");
            Console.WriteLine($"colour removed: {colours.DeQueue() ?? "List Empty"}");
            Console.WriteLine($"colours in queue: {colours.Display()}");
        }

        public record Student(string Name, int age);
        private static void StudentStack()
        {
            Student studentA = new ("Bon Jovi", 64);
            Student studentB = new ("Marie Smith", 22);
            Student studentC = new ("James Sweeper", 23);
            Student studentD = new ("Katie Hackitt", 19);
            StaticStack<Student> studentStack = new (3);
            studentStack.Push(studentA);
            studentStack.Push(studentB);
            studentStack.Push(studentC);
            Console.WriteLine($"Students are: {studentStack.Display()}");
            Console.WriteLine($"Top student is: {studentStack.Pop()}");
            //studentStack.Push(studentD);
            Console.WriteLine($"Students are: {studentStack.Display()}");
            // studentStack.Push(studentA);
        }

        private static void NumberQueue()
        {
            StaticQueue<int> numbers = new (20);
            for (int i = 1; i <= 20; i++)
            {
                numbers.EnQueue(i);
            }
            Console.WriteLine(numbers.Size);
            Console.WriteLine(numbers.Display());
            //numbers.EnQueue(144);
        }
    }
}
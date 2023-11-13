using System;
using QueuesAndStacks.Classes;

namespace QueuesAndStacks
{
    internal class Program
    {
        static void Main()
        {
            // Write your test calling code in this class
            StaticQueue<string> SPSQueue = new StaticQueue<string>(5);
            SPSQueue.EnQueue("Cat");
            Console.WriteLine(SPSQueue.Display());
        }
    }
}
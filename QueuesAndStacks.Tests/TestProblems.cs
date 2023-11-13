using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using QueuesAndStacks.Classes;

namespace QueuesAndStacks.Tests
{
    [TestClass]
    public class TestProblems
    {
        [TestMethod]
        [DataRow("int(input('What is your name? '))", true)]
        [DataRow("int(input('What is your name? ')", false)]
        [DataRow("7*((5*3) + (8+12)) / (15+3) ", true)]
        [DataRow("7*((5*3) + (8+12)) / 15+3) ", false)]
        public void TestBracketsMatch(string input, bool expectedValue)
        {
           bool result = Problems.AreBracketsValid(input);
           Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void TestReverseStack()
        {
            StaticStack<string> stack = new(4);
            stack.Push("apples");
            stack.Push("pears");
            stack.Push("oranges");
            stack.Push("mango");
            Problems.ReverseStack(stack);
            string expectedValue = "[apples, pears, oranges, mango]";
            Assert.AreEqual(expectedValue, stack.Display()); ;
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueuesAndStacks.Classes;
using System;

namespace QueuesAndStacks.Tests
{
    [TestClass]
    public class TestStaticQueue
    {
        [TestMethod]
        public void TestThrowsExceptionWhenQueueIsFull()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(4);
            staticQueue.EnQueue(5);
            staticQueue.EnQueue(5);
            staticQueue.EnQueue(5);
            staticQueue.EnQueue(5);
            var ex = Assert.ThrowsException<InvalidOperationException>(() => staticQueue.EnQueue(22));

            Assert.AreEqual("Queue is full", ex.Message);
        }

        [TestMethod]
        public void TestEmptyQueueIsEmpty()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(10);
            Assert.IsTrue(staticQueue.IsEmpty());
        }

        [TestMethod]
        public void TestQueueWithItemsIsNotEmpty()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(10);
            staticQueue.EnQueue(5);
            Assert.IsFalse(staticQueue.IsEmpty());
        }

        [TestMethod]
        public void TestQueueCapacity()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(5);
            staticQueue.EnQueue(5);
            Assert.AreEqual(staticQueue.Capacity, 5);
        }

        [TestMethod]
        public void TestEnQueueDeQueue()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(5);
            staticQueue.EnQueue(5);
            staticQueue.EnQueue(3);
            Assert.AreEqual(staticQueue.DeQueue(), 5);
        }

        [TestMethod]
        public void TestQueueIsCircular()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(5);
            staticQueue.EnQueue(2);
            staticQueue.EnQueue(3);
            staticQueue.EnQueue(22);
            staticQueue.EnQueue(12);
            staticQueue.EnQueue(15);
            Assert.AreEqual(staticQueue.DeQueue(), 2);
            staticQueue.EnQueue(9);
            Assert.AreEqual(staticQueue.DeQueue(), 3);
        }

        [TestMethod]
        public void TestIsFull()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(5);
            staticQueue.EnQueue(2);
            staticQueue.EnQueue(3);
            staticQueue.EnQueue(22);
            staticQueue.EnQueue(12);
            staticQueue.EnQueue(15);
            Assert.IsTrue(staticQueue.IsFull());
        }

        [TestMethod]
        public void TestIsFullWhenNotFull()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(5);
            staticQueue.EnQueue(2);
            staticQueue.EnQueue(3);
            staticQueue.EnQueue(22);
            staticQueue.EnQueue(12);
            staticQueue.EnQueue(15);
            staticQueue.DeQueue();
            Assert.IsFalse(staticQueue.IsFull());
        }

        [TestMethod]
        public void TestSizeIsCorrect()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(5);
            staticQueue.EnQueue(2);
            staticQueue.EnQueue(3);
            staticQueue.EnQueue(22);
            staticQueue.EnQueue(12);
            staticQueue.DeQueue();
            Assert.AreEqual(staticQueue.Size, 3);
        }

        [TestMethod]
        public void TestDisplayWhenEmpty()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(5);
            Assert.AreEqual(staticQueue.Display(), "[]");
        }

        [TestMethod]
        public void TestDisplay()
        {
            StaticQueue<int> staticQueue = new StaticQueue<int>(5);
            staticQueue.EnQueue(22);
            staticQueue.EnQueue(12);
            Assert.AreEqual(staticQueue.Display(), "[22, 12]");
        }

    }
}
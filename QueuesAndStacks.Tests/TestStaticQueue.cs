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
			StaticQueue<int> staticQueue = new(4);
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
			StaticQueue<int> staticQueue = new(10);
			Assert.IsTrue(staticQueue.IsEmpty());
		}

		[TestMethod]
		public void TestQueueWithItemsIsNotEmpty()
		{
			StaticQueue<int> staticQueue = new(10);
			staticQueue.EnQueue(5);
			Assert.IsFalse(staticQueue.IsEmpty());
		}

		[TestMethod]
		public void TestQueueCapacity()
		{
			StaticQueue<int> staticQueue = new(5);
			staticQueue.EnQueue(5);
			Assert.AreEqual(staticQueue.Capacity, 5);
		}

		[TestMethod]
		public void TestEnQueueDeQueue()
		{
			StaticQueue<int> staticQueue = new(5);
			staticQueue.EnQueue(5);
			staticQueue.EnQueue(3);
			Assert.AreEqual(5, staticQueue.DeQueue());
		}

		[TestMethod]
		public void TestQueueIsCircular()
		{
			StaticQueue<int> staticQueue = new(5);
			staticQueue.EnQueue(2);
			staticQueue.EnQueue(3);
			staticQueue.EnQueue(22);
			staticQueue.EnQueue(12);
			staticQueue.EnQueue(15);
			Assert.AreEqual(2, staticQueue.DeQueue());
			staticQueue.EnQueue(9);
			Assert.AreEqual(3, staticQueue.DeQueue());
		}

		[TestMethod]
		public void TestIsFull()
		{
			StaticQueue<int> staticQueue = new(5);
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
			StaticQueue<int> staticQueue = new(5);
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
			StaticQueue<int> staticQueue = new(5);
			staticQueue.EnQueue(2);
			staticQueue.EnQueue(3);
			staticQueue.EnQueue(22);
			staticQueue.EnQueue(12);
			staticQueue.DeQueue();
			Assert.AreEqual(3, staticQueue.Size);
		}

		[TestMethod]
		public void TestDisplayWhenEmpty()
		{
			StaticQueue<int> staticQueue = new(5);
			Assert.AreEqual("[]", staticQueue.Display());
		}

		[TestMethod]
		public void TestDisplay()
		{
			StaticQueue<int> staticQueue = new(5);
			staticQueue.EnQueue(22);
			staticQueue.EnQueue(12);
			Assert.AreEqual("[22, 12]", staticQueue.Display());
		}

		[TestMethod]
		public void TestDisplayWhenFull()
		{
			StaticQueue<int> staticQueue = new(5);
			staticQueue.EnQueue(52);
			staticQueue.EnQueue(42);
			staticQueue.EnQueue(32);
			staticQueue.EnQueue(22);
			staticQueue.EnQueue(12);
			Assert.AreEqual("[52, 42, 32, 22, 12]", staticQueue.Display());
		}

	}
}
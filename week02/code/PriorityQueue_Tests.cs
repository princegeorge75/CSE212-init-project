using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue several items with different priorities and remove them
    // Expected Result: Items should be dequeued in order of highest priority
    // Defect(s) Found: Original code skipped last item; also broke FIFO tie-break rule
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue()); // highest priority
        Assert.AreEqual("C", priorityQueue.Dequeue()); // next highest
        Assert.AreEqual("A", priorityQueue.Dequeue()); // lowest
    }

    [TestMethod]
    // Scenario: Enqueue items with same priority and verify FIFO is respected
    // Expected Result: Items dequeued in the order they were added
    // Defect(s) Found: Original code used >= and favored newer items (LIFO) 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("X", 5);
        priorityQueue.Enqueue("Y", 5);
        priorityQueue.Enqueue("Z", 5);

        Assert.AreEqual("X", priorityQueue.Dequeue());
        Assert.AreEqual("Y", priorityQueue.Dequeue());
        Assert.AreEqual("Z", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue
    // Expected Result: Exception should be thrown with correct message
    // Defect(s) Found: No defect, passed as expected
    public void TestPriorityQueue_Empty()
    {
        var queue = new PriorityQueue();

        try
        {
            queue.Dequeue();
            Assert.Fail("Expected exception was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}
/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the end of the queue (FIFO)
    /// </summary>
    public void Enqueue(Person person)
    {
        _queue.Add(person);  // ✅ append to end
    }

    /// <summary>
    /// Remove the person at the front of the queue
    /// </summary>
    public Person Dequeue()
    {
        var person = _queue[0];  // ✅ remove from front
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

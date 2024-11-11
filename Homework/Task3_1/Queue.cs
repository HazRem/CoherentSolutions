using Task3_1;

public class Queue<T> : IQueue<T> where T : struct
{
    private LinkedList<T> list = new LinkedList<T>();
    private readonly int maxCapacity;

    public Queue(int maxCapacity = int.MaxValue)
    {
        this.maxCapacity = maxCapacity;
    }

    public void Enqueue(T item)
    {
        if (list.Count >= maxCapacity)
            throw new InvalidOperationException("Queue has reached its maximum capacity.");

        list.AddLast(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Cannot dequeue from an empty queue.");

        T value = list.First.Value;
        list.RemoveFirst();
        return value;
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }

    public override string ToString()
    {
        return string.Join(", ", list);
    }
}
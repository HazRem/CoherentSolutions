public interface IQueue<T> where T : struct
{
    void Enqueue(T item);
    T Dequeue();
    bool IsEmpty();
}

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

public static class QueueExtensions
{
    public static IQueue<T> Tail<T>(this IQueue<T> queue) where T : struct
    {
        Queue<T> tailQueue = new Queue<T>();
        Queue<T> tempQueue = new Queue<T>();

        if (!queue.IsEmpty())
        {
            queue.Dequeue();
        }

        while (!queue.IsEmpty())
        {
            T item = queue.Dequeue();
            tailQueue.Enqueue(item);
            tempQueue.Enqueue(item);
        }

        while (!tempQueue.IsEmpty())
        {
            queue.Enqueue(tempQueue.Dequeue());
        }

        return tailQueue;
    }
}
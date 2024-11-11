using Task3_1;

Console.WriteLine("QUEUE TEST:");
QueueTest();
Console.WriteLine();
Console.WriteLine("QUEUE TEST WITH EXCEPTIONS:");
QueueTestWithExceptions();



static void QueueTest()
{
    IQueue<int> queue = new Queue<int>();
    queue.Enqueue(1);
    queue.Enqueue(3);
    queue.Enqueue(5);
    queue.Enqueue(7);

    Console.WriteLine("Original Queue: " + queue);

    IQueue<int> tailQueue = queue.Tail();

    Console.WriteLine("Original Queue after Tail: " + queue);
    Console.WriteLine("Tail Queue: " + tailQueue);

    Console.WriteLine("Dequeue elements from Tail Queue:");
    while (!tailQueue.IsEmpty())
    {
        Console.WriteLine(tailQueue.Dequeue());
    }
}

static void QueueTestWithExceptions()
{
    IQueue<int> queue = new Queue<int>(3);

    try
    {
        queue.Enqueue(1);
        queue.Enqueue(3);
        queue.Enqueue(5);
        Console.WriteLine("Original Queue: " + queue);

        Console.WriteLine("Attempting to enqueue beyond capacity:");
        queue.Enqueue(7);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("Exception: " + ex.Message);
    }

    try
    {
        Console.WriteLine("Attempting to dequeue all elements:");
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());

        Console.WriteLine("Attempting to dequeue from an empty queue:");
        Console.WriteLine(queue.Dequeue());
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("Exception: " + ex.Message);
    }
}
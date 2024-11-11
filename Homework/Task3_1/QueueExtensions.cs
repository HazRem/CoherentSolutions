using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
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
}

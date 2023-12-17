using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba2
{
    public static class QueueString
    {
        public static double FirstOrDefault(this Queue<double> queue)
        {
            if (queue.Count > 0)
            {
                for (var i = 0; i < queue.Count; i++)
                {
                    var currentFirstElement = queue.Dequeue();
                    var str = queue.Peek().ToString();
                    if (str.Contains(".") || str.Contains(",")) return queue.Peek();
                    queue.Enqueue(currentFirstElement);
                }
            }

            throw new InvalidOperationException("xd");
        }

        public static double LastOrDefault(this Queue<double> queue)
        {
            if (queue.Count > 0) return queue.Last();
            throw new InvalidOperationException("aboba");
        }
    }
}
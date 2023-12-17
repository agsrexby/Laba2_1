using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Laba2

{
    public class Queue
    {
        private  Queue<double> _queue = new(10);
 
        public Queue(Queue<double> queue)
        {
            _queue = queue;
        }
        public static Queue operator +(Queue q1, double q2)
        {
            q1._queue.Enqueue(q2);
            return new Queue(q1._queue);
        }
        public static Queue operator -(Queue q1, double q2)
        {
            var queueCount = q1._queue.Count; 
 
            for (var i = 0; i < queueCount; i++)
            {
                var currentFirstElement = q1._queue.Dequeue();  
 
                if (currentFirstElement != q2) 
                {
                    q1._queue.Enqueue(currentFirstElement); 
                }
            }
            return new Queue(q1._queue);
        }
 
        public static bool operator true(Queue q1)
        {
            return q1._queue.Count == 0;
        }
 
        public static bool operator false(Queue q1)
        {
            throw new NotImplementedException();
        }
 
        public static Queue operator <(Queue q1, Queue q2)
        {
            var queSort = new Queue<double>(20);
            foreach (var q in q1._queue)
            {
                queSort.Enqueue(q);
            }
            foreach (var q in q2._queue)
            {
                queSort.Enqueue(q);
            }
            queSort = new Queue<double>(queSort.OrderByDescending(x => x));
            return new Queue(queSort);
        }
        // public static implicit operator int(Queue queue)
        // {
        //     return queue._queue.Count;
        // }
 
        public static Queue operator >(Queue q1, Queue q2)
        {
            throw new NotImplementedException();
        }
 
        public override string ToString()
        {
            var queue = string.Join(", ", _queue);
            return "[" + queue + "]";
        }
    }
}
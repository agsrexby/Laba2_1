using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var quetest1 = new Queue<double>(10);
            var quetest2 = new Queue<double>(10);
            quetest1.Enqueue(1);
            quetest1.Enqueue(5.1);
            quetest2.Enqueue(3);
            quetest2.Enqueue(4);
            var que1 = new Queue(quetest1);
            var que2 = new Queue(quetest2);
            Console.WriteLine(que1+2.5);
            Console.WriteLine(que1<que2);
            if (que1) Console.WriteLine("Очередь пустая");
            else Console.WriteLine("Очередь не пустая");
            Console.WriteLine(quetest1.FirstOrDefault());
            Console.WriteLine(quetest1.LastOrDefault());
        }
    }
}
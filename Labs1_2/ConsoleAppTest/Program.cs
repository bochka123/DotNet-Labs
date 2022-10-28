using System;
using Queue;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Collections.Generic.Queue<String> vs = new System.Collections.Generic.Queue<String>();
            Queue<String> queue = new Queue<String>();

            queue.Enqueue("dsdd");
            queue.Enqueue("dsasddd");
            queue.Enqueue("dsddfd");
            queue.Enqueue("dssssdd");
            Console.WriteLine(queue.Contains("dsdd"));
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }
    }
}

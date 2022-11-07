using System;
using System.Threading;
using Queue;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            commonTests();
            testEvents();
            testSyncRoot();
        }

        static void commonTests()
        {
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
            list.Add(1);
            list.Add(2);    
            list.Add(3);
            list.Add(4);
            Queue<int> queue1 = new Queue<int>(3, 1, 5, 6, 6, 1, 6, 8, 37);
            Queue<int> queue2 = new Queue<int>(list);
            Console.Write("Queue1: ");
            foreach (int item in queue1)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            Console.Write("Queue2: ");
            foreach (int item in queue2)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Peek method test: {queue1.Peek()}");
            queue1.Enqueue(1);
            Console.Write("Enqueue method test: ");
            foreach (int item in queue1)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            QueueNode<int> element = new QueueNode<int>(5);
            queue1.Dequeue();
            Console.WriteLine($"Dequeue method test: {queue1.Peek()}");
            Console.WriteLine($"Contains method test: {queue1.Contains(37)}");
            Console.WriteLine($"Contains method test: {queue1.Contains(30)}");
            Console.WriteLine($"Clear method test: Number of elements before clear: {queue1.Count}");
            Console.Write("CopyTo method test: ");
            int[] arr = new int[12];
            queue1.CopyTo(arr, 1);
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            queue1.Clear();
            Console.WriteLine($"Clear method test: Number of elements after clear: {queue1.Count}");
        }
        private static void testSyncRoot()
        {
            Queue<int> queue1 = new Queue<int>(3, 1, 5, 6, 6, 1, 6, 8, 37);
            int x = 1;
            Console.WriteLine("\nAsync test:");
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"Thread {i}";
                myThread.Start();
            }

            void Print()
            {
                lock (queue1.SyncRoot)
                {
                    foreach (int i in queue1)
                    {
                        Console.Write($"{i * x} ");
                    }
                    Console.WriteLine($" - thread {x}");
                    x++;
                }
            }
        }
        private static void testEvents()
        {
            Queue<int> queue1 = new Queue<int>(3, 1, 5, 6, 6, 1, 6, 8, 37);
            Console.WriteLine("\nEvents: ");
            queue1.EventEnqueue += EnqueueTest;
            queue1.EventDequeue += DequeueTest;
            queue1.EventClear += ClearTest;
            queue1.Enqueue(22);
            queue1.Dequeue();
            queue1.Clear();
        }

        private static void EnqueueTest(QueueNode<int> element)
        {
            Console.WriteLine($"{element.Value} is Added!");
        }
        private static void DequeueTest(QueueNode<int> element)
        {
            Console.WriteLine($"{element.Value} is Removed!");
        }
        private static void ClearTest()
        {
            Console.WriteLine("Queue is Cleared!");
        }
    }
}

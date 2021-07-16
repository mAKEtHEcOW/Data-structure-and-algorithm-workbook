using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "a", "b", "c", "d" };
            //int N = 100000;
            //Array1Queue<int> queue1 = new Array1Queue<int>();
            //long t1 = Test.TestQueue(queue1, N);

            //Console.WriteLine("Queue1: " + t1 + "ms");//18670ms 

            //Array2Queue<int> queue2 = new Array2Queue<int>();
            //long t2 = Test.TestQueue(queue2, N);//
            //Console.WriteLine("Queue2: " + t2 + "ms");//8ms

            LinkedList2Queue<int> queue = new LinkedList2Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(2);
            queue.Enqueue(2);
            Console.WriteLine(queue);
            queue.Dequeue();
            Console.WriteLine(queue);
            Console.ReadKey();
        }
    }
    class Test
    {
        public static long TestQueue(IQueue<int> queue, int N)
        {
            Stopwatch t1 = new Stopwatch();
            t1.Start();
            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(i);
            }
            for (int i = 0; i < N; i++)
            {
                queue.Dequeue();
            }
            t1.Stop();
            return t1.ElapsedMilliseconds;
        }
    }
}

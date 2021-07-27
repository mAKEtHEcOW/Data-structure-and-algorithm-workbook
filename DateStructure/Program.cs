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
            LinkedList3Dictionary<int, string> dick = new LinkedList3Dictionary<int, string>();

            for (int i = 0; i < s.Length; i++)
            {
                dick.Add(i, s[i]);
            }

            Console.WriteLine(dick);


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

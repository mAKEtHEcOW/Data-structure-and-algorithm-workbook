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
            LinkedList1Set<string> set = new LinkedList1Set<string>();
            Console.WriteLine(set);
            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);
            }
            Console.WriteLine(set);
            set.Add(s[1]);
            Console.WriteLine(set);
            set.Remove("a");
            Console.WriteLine(set);
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

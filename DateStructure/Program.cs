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
            Console.WriteLine("My Beloved Teacher");
            List<string> words = TestHelper.ReadFile("测试文件1/My Beloved Teacher.txt");
            Console.WriteLine("总单词数: " + words.Count);
            Stopwatch t1 = new Stopwatch();
            LinkedList3Dictionary<string,int> dick = new LinkedList3Dictionary<string,int>();

            t1.Start();
            foreach(var word in words)
            {
                if (!dick.ContainsKey(word))
                    dick.Add(word, 1);
                else
                {
                    dick.Set(word, dick.Get(word) + 1);
                }
            }
            t1.Stop();
            Console.WriteLine("不同的单词总数：" + dick.Count);
            Console.WriteLine("sara出现的频次: " + dick.Get("sara"));



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

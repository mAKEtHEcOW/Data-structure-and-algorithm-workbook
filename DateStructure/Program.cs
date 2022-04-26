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

        }

        public static LinkedListNode<int> ReverseList(LinkedListNode<int> head)
        {
            Stack<LinkedListNode<int>> st1 = new Stack<LinkedListNode<int>>();
            while (head != null)
            {
                st1.Push(head);
                head = head.Next;
            }

            LinkedListNode<int> newHead = new LinkedListNode<int>(st1.Peek().Value);
            LinkedListNode<int> result = newHead;

            while (st1.Count > 0)
            {
                newHead = st1.Pop();
                ;
                newHead = newHead.Next;
            }

            return result;
        }


        public static int[] BubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }   
                }
            }
            return nums;
        }
    
    public static int Fibonacci(int n)
    {
        if (n <= 2)
        {
            return 1;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
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

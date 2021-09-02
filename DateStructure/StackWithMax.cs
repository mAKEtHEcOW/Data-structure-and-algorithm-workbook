using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class StackWithMax<E> where E : IComparable
    {
        List<int> list = new List<int>();
        private int N = 0;
        public void Push(int e)
        {
            list.Add(e);
            N++;
        }

        public int Pop()
        {
            int e = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            N--;
            return e;
        }

        public int Max()
        {
            int max = -1000000;
            for (int i = 0; i < N; i++)
            {
                int temp = Pop();
                if (temp > max)
                {
                    max = temp;
                }
            }
            return max;

        }
    }
}

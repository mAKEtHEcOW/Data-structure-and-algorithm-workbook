using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    //循环数组
    class Array2Queue<E> : IQueue<E>
    {
        private Array2<E> arr;

        public int Count { get { return arr.Count; } }

        public bool IsEmpty { get { return arr.IsEmpty; } }

        public Array2Queue(int capacity)
        {
            arr = new Array2<E>(capacity);
        }
        public Array2Queue()
        {
            arr = new Array2<E>();
        }

        public E Dequeue()
        {
            return arr.RemoveFirst();
        }

        public void Enqueue(E e)
        {
            arr.AddLast(e);
        }

        public E Peak()
        {
            return arr.GetFirst();
        }

        public override string ToString()
        {
            return "Queue: Count="+ arr.Count+" front " + arr.ToString() + " tail";
        }
    }
}

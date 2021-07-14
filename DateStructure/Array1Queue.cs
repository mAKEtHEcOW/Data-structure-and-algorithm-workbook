using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class Array1Queue<E> : IQueue<E>
    {
        private Array1<E> arr;

        public int Count { get { return arr.Count; } }

        public bool IsEmpty { get { return arr.IsEmpty; } }

        public Array1Queue(int capacity)
        {
            arr = new Array1<E>(capacity);
        }
        public Array1Queue()
        {
            arr = new Array1<E>();
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
            return "Queue: front " + arr.ToString() + "tail";
        }
    }
}

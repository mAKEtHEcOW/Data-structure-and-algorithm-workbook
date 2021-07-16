using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class LinkedListQueue<E> : IQueue<E>
    {
        private LinkedList1<E> list;

        public LinkedListQueue()
        {
            list = new LinkedList1<E>();
        }

        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.isEmpty; } }

        public E Dequeue()
        {
            return list.RemoveFirst();
        }

        public void Enqueue(E e)
        {
            list.AddLast(e);
        }

        public E Peak()
        {
            return list.GetFirst();
        }

        public override string ToString()
        {
            return list.ToString();
        }
    }
}

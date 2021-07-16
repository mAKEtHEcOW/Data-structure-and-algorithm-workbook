using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class LinkedList2Queue<E> : IQueue<E>
    {
        LinkedList2<E> list;

        public LinkedList2Queue()
        {
            list = new LinkedList2<E>();
        }
        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }

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
            return "LinkedList2Queue: front "+list.ToString()+ " tail";
        }
    }
}

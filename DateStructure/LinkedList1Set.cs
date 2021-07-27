using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class LinkedList1Set<E> : ISet<E>
    {

        private LinkedList1<E> list = new LinkedList1<E>();
        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.isEmpty; } }

        public void Add(E e)
        {
            if(IsEmpty)
            {
                list.AddFirst(e);
                return;
            }
            if (Contains(e))
            {
                return;
            }
            list.AddFirst(e);
        }

        public bool Contains(E e)
        {
            return list.Contains(e);
        }

        public void Remove(E e)
        {
            list.Remove(e);
        }

        public override string ToString()
        {
            return list.ToString();
        }
    }
}

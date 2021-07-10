using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class LinkedList1Stack<E> : IStack<E>
    {
        LinkedList1<E> list = new LinkedList1<E>();
        public int Count { get { return list.Count; } }

        public bool isEmpty { get { return list.isEmpty; } }

        public void push(E e)
        {
            list.AddFirst(e);
        }
        
        public E Pop()
        {
            return list.RemoveFirst();
        }

        
        public E peak()
        {
            return list.GetFirst();
        }

        public override string ToString()
        {
            return "Stack: " + "top " +list.ToString() ;
        }
    }
}

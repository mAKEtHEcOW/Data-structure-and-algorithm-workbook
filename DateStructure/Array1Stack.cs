using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class Array1Stack<E>:IStack<E>
    {
        private Array1<E> arr;

        public int Count { get { return arr.Count; } }

        public bool isEmpty { get { return arr.IsEmpty; } }

        public Array1Stack(int capacity)
        {
            arr = new Array1<E>(capacity);
        }

        public Array1Stack()
        {
            arr = new Array1<E>();
        }

        public void push(E e)
        {
            arr.AddLast(e);
        }

        public E Pop()
        {
            return arr.RemoveLast();
        }

        public E peak()
        {
            return arr.GetLast();
        }

        public override string ToString()
        {
            return "Stack: " + arr.ToString() + "top";
        }
    }
}

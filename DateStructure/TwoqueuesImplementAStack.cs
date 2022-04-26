using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class TwoqueuesImplementAStack<E> : IStack<E>
    {
        private Array1Queue<E> q1;
        private Array1Queue<E> q2;
        private Array1Queue<E> curQueue;
        private Array1Queue<E> emptyQueue;
        

        public TwoqueuesImplementAStack()
        {
            q1 = new Array1Queue<E>();
            q2 = new Array1Queue<E>();
        }
        public int Count
        {
            get { return q1.Count + q2.Count;  }
        }

        public bool isEmpty
        {
            get { return Count == 0; }
        }

        public E Peak()
        {
            curQueue = q1.Count == 0 ? q2 : q1;
            emptyQueue = q1.Count == 0 ? q1 : q2;

            while (curQueue.Count > 1)
            {
                emptyQueue.Enqueue(curQueue.Dequeue());
            }
            E peak = curQueue.Peak();
            emptyQueue.Enqueue(curQueue.Dequeue());
            return peak;
        }

        public E Pop()
        {
            curQueue = q1.Count == 0 ? q2 : q1;
            emptyQueue = q1.Count == 0 ? q1 : q2;

            while (curQueue.Count > 1)
            {
                emptyQueue.Enqueue(curQueue.Dequeue());
            }

            return curQueue.Dequeue();
        }

        public void Push(E e)
        {
            curQueue = q1.Count == 0 ? q2 : q1;
            curQueue.Enqueue(e);
        }

        public override string ToString()
        {
            curQueue = q1.Count == 0 ? q2 : q1;
            emptyQueue = q1.Count == 0 ? q1 : q2;
            StringBuilder res = new StringBuilder();
            res.Append("stack: bottom ");
            while (curQueue.Count > 0)
            {
                E temp = curQueue.Dequeue();
                res.Append(temp + ",");
                emptyQueue.Enqueue(temp);
            }
            return res.ToString();
        }
    }
}

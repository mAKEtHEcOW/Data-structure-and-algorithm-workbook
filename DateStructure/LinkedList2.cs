using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class LinkedList2<E>
    {
        private class Node
        {
            public E e;
            public Node next;

            public Node(E e, Node next)
            {
                this.e = e;
                this.next = next;
            }
            public Node(E e)
            {
                this.e = e;
                this.next = null;
            }

            public override string ToString()
            {
                return e.ToString();
            }

        }

        private Node head;
        private Node tail;
        private int N;

        public LinkedList2()
        {
            head = null;
            tail = null;
            N = 0;
        }

        public int Count { get { return N; } }
        public bool IsEmpty { get { return N == 0; } }

        public void AddLast(E e)
        {
            if (IsEmpty)
            {
                //错误写法
                //head = new Node(e);
                //tail = new Node(e);
                head = tail = new Node(e);
            }
            else
            {
                tail.next = new Node(e);
                tail = tail.next;
                
            }
            N++;

        }

        public E RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("链表为空");
            }

            Node del = head;
            head = head.next;
            N--;

            //?
            if(head == null)
            {
                tail = null;
            }
            return del.e;
            
        }

        public E GetFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("链表为空");
            }
            return head.e;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //正常用法
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur + "->");
                cur = cur.next;
            }
            return res.ToString();
        }
    }
}

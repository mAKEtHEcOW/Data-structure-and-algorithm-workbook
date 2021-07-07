using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class LinkedList1<E>
    {
        private class Node //内部类，对用户屏蔽
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

        private int N;

        public LinkedList1()
        {
            head = null;
            N = 0;
        }

        public int Count
        {
            get { return N; }
        }

        public bool isEmpty
        {
            get { return N == 0; }
        }

        public void Add(int index, E e)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("索引不合法");
            }
            
            if(index == 0)
            {
                head = new Node(e);
            }
            else
            {
                Node pre = head;
                for (int i = 0; i < index - 1; i++)
                {
                    pre = pre.next;
                }
                Node node = new Node(e);
                node.next = pre.next;
                pre.next = node;
            }

            N++;
        }

        public void AddFirst(E e)
        {
            Add(0, e);
        }
        public void AddLast(E e)
        {
            Add(N, e);
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("LinkedList: count={0}                \n", N));
            //正常用法
            //int i = 0;
            //Node now = head;
            //while (i < N)
            //{
            //    res.Append(now + "->");
            //    now = now.next;
            //    i++;
            //}
            //不知道为什么错误
            //Node now = head;
            //for (int i = 0; i < N ; i++)
            //{
            //    res.Append(now);
            //    if (now.next != null)
            //    {
            //        res.Append("->");
            //    }
            //    now = now.next;
            //    i++;
            //}

            for (Node cur = head;cur!=null;cur = cur.next)
            {
                res.Append(cur+ "->");
            }

            res.Append("null");
            return res.ToString();
        }
    }
}

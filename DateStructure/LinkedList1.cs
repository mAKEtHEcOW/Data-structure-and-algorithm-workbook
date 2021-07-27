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
        //增加节点
        public void Add(int index, E e)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("索引不合法");
            }
            //第一次写错漏写了一新建node的next，没有连起来，一共两步，初始化、连接。
            //if (index == 0)
            //{
            //    head = new Node(e);
            //}
            if (index == 0)
            {
                //Node node = new Node(e);
                //node.next = head;
                //head = node;
                //这三行简洁写为
                head = new Node(e, head);
            }
            else
            {
                Node pre = head;
                for (int i = 0; i < index - 1; i++)
                {
                    pre = pre.next;
                }

                //Node node = new Node(e);
                //node.next = pre.next;
                //pre.next = node;
                //这三行简洁写法为
                pre.next = new Node(e, pre.next);
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
        //查找
        public E Get(int index)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("索引不合法");
            }
            Node cur = head;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            return cur.e;
        }
        public E GetFirst()
        {
            return Get(0);
        }
        public E GetLast()
        {
            return Get(N - 1);
        }
        public bool Contains(E e)
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.e.Equals(e))
                {
                    return true;
                }
                cur = cur.next;
            }
            return false;
        }
        public int IndexOf(E e)
        {
            int index = 0;
            Node cur = head;
            while (cur != null)
            {
                if (cur.e.Equals(e))
                {
                    return index;
                }
                cur = cur.next;
                index++;
            }
            return -1;
        }
        //更改
        public void Set(int index, E newE)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("索引不合法");
            }
            Node cur = head;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            cur.e = newE;
        }


        public E RemoveAt(int index)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("索引不合法");
            }
            if(head == null)
            {
                throw new ArgumentException("链表为空");
            }
            if (index == 0)
            {
                Node delNode = head;
                head = head.next;
                N--;
                return delNode.e;
            }
            else
            {
                Node pre = head;
                for (int i = 0; i < index - 1; i++)
                {
                    pre = pre.next;
                }
                Node delNode = pre.next;
                pre.next = delNode.next;
                N--;
                return delNode.e;
            }
        }
        public E RemoveFirst()
        {
            return RemoveAt(0);
        }
        public E RemoveLast()
        {
            return RemoveAt(N - 1);
        }
        public void Remove(E e)
        {
            if(head == null)
            {
                return;
            }
            if(head.e.Equals(e))
            {
                head = head.next;
                N--;
            }
            else
            {
                Node cur = head;
                Node pre = null;
                while (cur != null)
                {
                    if (cur.e.Equals(e))
                    {
                        break;
                    }
                    pre = cur;
                    cur = cur.next;
                }
                if (cur != null)
                {
                    pre = pre.next.next;
                    N--;
                }
            }
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

            res.Append("null");
            return res.ToString();
        }
    }
}

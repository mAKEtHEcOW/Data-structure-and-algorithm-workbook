using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class Array1<E>
    {
        //存储位置
        private E[] data;
        //实际存储数量
        private int N;

        public Array1(int capacity)
        {
            data = new E[capacity];
            N = 0;
        }

        public Array1() : this(10) { }//等价于下面注释
        //public Array1()
        //{
        //    data = new int[10];
        //    N = 0;
        //}

        //用属性访问容量
        public int Capacity
        {
            get { return data.Length; }
        }
        //用属性访问数组数据数量
        public int Count
        {
            get { return N; }
        }

        public bool IsEmpty
        {
            get { return N == 0; }
        }
        //增加
        public void Add(int index, E e)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("数组索引越界");
            }
            if (N == data.Length)//扩容判定
            {
                ResetCapacity(2 * data.Length);
            }
            for (int i = N - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = e;
            N++;
        }
        //复用提供尾部添加。
        public void AddLast(E e)
        {
            Add(N, e);
        }
        //复用首部添加。
        public void AddFirst(E e)
        {
            Add(0, e);
        }
        //删除
        public E RemoveAt(int index)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("数组索引越界");
            }
            E del = data[index];
            for (int i = index; i < N - 1; i++)
            {
                data[i] = data[i + 1];
            }
            N--;
            data[N] = default(E);
            //缩容判断
            if(N==data.Length/4)
            {
                ResetCapacity(data.Length / 2);
            }

            return del;
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
            int index = IndexOf(e);
            if (index != -1)
            {
                RemoveAt(index);
            }
        }
        
        //查找
        public E Get(int index)
        {
            if (index < 0 || index > N - 1)
            {
                throw new ArgumentException("数组索引越界");
            }
            return data[index];
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
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(e))
                {
                    return true;
                }
            }
            return false;
            //复用但是浪费性能
            //if(IndexOf(e)!=-1)
            //{
            //    return true;
            //}
            //return false;
        }
        public int IndexOf(E e)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(e))
                {
                    return i;
                }
            }
            return -1;
        }
        //更改
        public void Set(int index, E newE)
        {
            if (index < 0 || index > N - 1)
            {
                throw new ArgumentException("数组索引越界");
            }
            data[index] = newE;
        }
        //重写ToString
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //res.Append(string.Format("Array1: count={0} capacity={1}\n", N, data.Length));
            res.Append('[');
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N - 1)
                {
                    res.Append(", ");
                }
            }
            res.Append(']');
            return res.ToString();
        }

        //动态数组
        private void ResetCapacity(int newCapacity)
        {
            E[] newData = new E[newCapacity];
            for (int i = 0; i < N; i++)
            {
                newData[i] = data[i];
            }
            data = newData;
        }
    }
}

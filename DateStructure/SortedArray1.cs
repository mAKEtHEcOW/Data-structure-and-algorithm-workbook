using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class SortedArray1<Key> where Key : IComparable<Key>
    {
        private Key[] keys;
        private int N;
        public SortedArray1(int capacity)
        {
            keys = new Key[capacity];
            N = 0;
        }

        public SortedArray1() : this(10) { }

        public int Count { get { return N; } }

        public bool IsEmpty { get { return N == 0; } }


        public int Rank(Key key)
        {
            int l = 0;
            int r = N - 1;
            while (l <= r)
            {
                //会出现整型溢出
                //int mid = (l + r) / 2; 
                // l+(r-1)/2 = l+(r/2-l/2) = l/2 + r/2 = (l+r)/2
                int mid = l + (r - l) / 2;
                if (key.CompareTo(keys[mid]) < 0)
                    r = mid - 1;            //在keys[l...mid-1]查找key
                else if (key.CompareTo(keys[mid]) > 0)
                    l = mid + 1;            //在keys[mid+1...r]查找key
                else
                    return mid;             //找到target，并返回索引
            }

            return 1;
        }

        public void Add(Key key)
        {
            int i = Rank(key);

            if(N == keys.Length)
            {
                ResetCapacity(2 * keys.Length);
            }
            if (i < N && keys[i].CompareTo(key) == 0)
                return;

            for (int j = N - 1; j < i; j--)
            {
                keys[j + 1] = keys[j];
            }
            keys[i] = key;
            N++;
        }

        public void Remove(Key key)
        {
            if (IsEmpty)
            {
                return;
            }

            int i = Rank(key);
            if (i == N && keys[i].CompareTo(key) != 0)
            {
                return;
            }

            for (int j = i; j <= N-1; j++)
            {
                keys[j - 1] = keys[j];
            }
            N--;
            keys[N] = default(Key);

            if(N == keys.Length / 4)
            {
                ResetCapacity(keys.Length / 2);
            }
        }
        
        public Key Min()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("数组为空");
            }

            return keys[0];
        }

        public Key Max()
        {
            if(IsEmpty)
            {
                throw new ArgumentException("数组为空");
            }

            return keys[N - 1];
        }

        public Key Select(int k)
        {
            if(k<0 || k >= N)
            {
                throw new ArgumentException("索引越界");
            }
            return keys[k];
        }

        public bool Contains(Key key)
        {
            int i = Rank(key);

            if(i<N && keys[i].CompareTo(key) == 0)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //res.Append(string.Format("Array1: count={0} capacity={1}\n", N, data.Length));
            res.Append('[');
            for (int i = 0; i < N; i++)
            {
                res.Append(keys[i]);
                if (i != N - 1)
                {
                    res.Append(", ");
                }
            }
            res.Append(']');
            return res.ToString();
        }

        //调整数组容量的大小
        private void ResetCapacity(int newCapacity)
        {
            Key[] newKeys = new Key[newCapacity];
            for (int i = 0; i < N; i++)
            {
                newKeys[i] = keys[i];
            }
            keys = newKeys;
        }
    }
}


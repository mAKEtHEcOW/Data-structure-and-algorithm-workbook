using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class LinkedList3Dictionary<key, Value> : IDictionary<key, Value>
    {
        private LinkedList3<key, Value> list;
        public int Count { get { return list.Count; } }

        public bool IsEmpty { get { return list.IsEmpty; } }

        public LinkedList3Dictionary()
        {
            list = new LinkedList3<key, Value>();
        }

        public void Add(key key, Value value)
        {
            list.Add(key, value);
        }

        public bool ContainsKey(key key)
        {
            return list.Contains(key);
        }

        public Value Get(key key)
        {
            return list.Get(key);
        }

        public void Remove(key key)
        {
            list.Remove(key);
        }

        public void Set(key key, Value newValue)
        {
            list.Set(key, newValue);
        }
    }
}

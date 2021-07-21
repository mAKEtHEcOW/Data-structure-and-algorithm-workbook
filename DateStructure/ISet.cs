using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    interface ISet<E>
    {
        int Count { get; }
        bool IsEmpty { get; }

        void Add(E e);

        bool Contains(E e);

        void Remove(E e);
    }
}

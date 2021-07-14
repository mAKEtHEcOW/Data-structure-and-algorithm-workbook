using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    interface IQueue<E>
    {
        int Count { get; }

        bool IsEmpty { get; }

        void Enqueue(E e);

        E Dequeue();

        E Peak();
    }
}

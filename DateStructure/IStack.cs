using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    interface IStack<E>
    {
        int Count { get; }
        bool isEmpty { get; }
        void push(E e);
        E Pop();
        E peak();
        
    }
}

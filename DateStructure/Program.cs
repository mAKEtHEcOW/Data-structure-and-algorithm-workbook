using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "a", "b", "c", "d" };
            Array1<string> a = new Array1<string>();
            for (int i = 0; i < s.Length; i++)
            {
                a.AddLast(s[i]);
            }
            a.Get(4);
            Console.Read();
        }
    }
}

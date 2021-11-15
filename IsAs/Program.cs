using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAs
{
    class ClassA { }
    class ClassB : ClassA { }
    class Program
    {
        static void Main(string[] args)
        {
            ClassB b = new ClassB();
            ClassA a = null;
            if (b is ClassA)
            {
                a = (ClassA)b;

            }
            else
            {
                a = null;
            }

            a = b as ClassA;
            Console.ReadKey();
        }
    }
}

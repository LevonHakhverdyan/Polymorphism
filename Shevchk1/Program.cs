using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchk1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass instance = new DerivedClass();
            instance.SomeMetod1();
            instance.SomeMetod2();
            DerivedClass instance2 = instance as DerivedClass;
            instance2.SomeMetod1();
            instance2.SomeMetod2();
            Console.ReadKey();
        }
    }
}

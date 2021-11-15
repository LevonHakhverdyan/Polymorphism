using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchuk
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass instance1 = new DerivedClass();
            instance1.SomeMetod1();
            instance1.SomeMetod2();
            DerivedClass instance2 = instance1 as DerivedClass;
            instance2.SomeMetod1();
            instance2.SomeMetod2();
            Console.ReadKey();
        }
    }
}

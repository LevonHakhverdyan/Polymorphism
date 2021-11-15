using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchuk2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BaseClass");

            BaseClass i1 = new DerivedClass();
            i1.SomeMetod1();
            i1.SomeMetod2();

            DerivedClass i2 = new DerivedClass();
            i2.SomeMetod1();
            i2.SomeMetod2();

            DerivedFromDerivedClass i3 = new DerivedFromDerivedClass();
            i3.SomeMetod1();
            i3.SomeMetod2();

            Console.ReadKey();



        }
    }
}

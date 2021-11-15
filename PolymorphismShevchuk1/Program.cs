using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismShevchuk1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass instance = new DerivedClass();
            instance.SomeMetod1();
            instance.SomeMetod2();
            Console.ReadKey();
        }
    }
}

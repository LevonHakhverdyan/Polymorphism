using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchuk3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("enter key 0,1 or 2:");
                string s = Console.ReadLine();
                if (s == "0")
                    new BaseClass().SomeMetods();
                if (s == "1")
                    (new DerivedClass() as BaseClass).SomeMetods();
                if (s == "2")
                    new DerivedClass().SomeMetods();
                Console.WriteLine("\n");

            }
        }
    }
}

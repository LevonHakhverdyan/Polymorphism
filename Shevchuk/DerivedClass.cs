using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchuk
{
    public class DerivedClass : BaseClass
    {
        public new void SomeMetod1() { Console.WriteLine("3"); }
        public void SomeMetod2() { Console.WriteLine("4"); }
    }
}

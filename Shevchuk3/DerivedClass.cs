using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchuk3
{
    public class DerivedClass :BaseClass
    {
        public new void SomeMetods()
        {
            SomeMetod1();
            SomeMetod2();
        }
        public new void SomeMetod1() { Console.WriteLine("3."); }
        public override void SomeMetod2() { Console.WriteLine("4."); }
    }
}

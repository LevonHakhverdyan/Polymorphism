using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchuk2
{
   public class DerivedClass : BaseClass
    {
        public void SomeMetod1() { Console.WriteLine("3"); }
        public override void SomeMetod2() { Console.WriteLine("4"); }
    }
}

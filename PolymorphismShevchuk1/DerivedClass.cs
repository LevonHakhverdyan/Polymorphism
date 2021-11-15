using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismShevchuk1
{
    public class DerivedClass : BaseClass
    {
        public new void SomeMetod1() { Console.WriteLine("3"); }
        public sealed override void SomeMetod2() { Console.WriteLine("4"); }


    }
}

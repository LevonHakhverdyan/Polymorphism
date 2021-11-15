using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchk1
{
    public class BaseClass
    {
        public void BaseClassMetod() // shablonni metod
        {
            SomeMetod1();
            SomeMetod2();
        }
        public virtual void SomeMetod1() { Console.WriteLine("1"); }
        public virtual void SomeMetod2() { Console.WriteLine("2"); }
    }
}

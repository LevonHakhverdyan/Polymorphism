using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchuk4
{
    public class DerivedClass :BaseClass
    {
        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
        public void NVMethod()
        {
            Console.WriteLine("NVMethod form DerivedClass");

        }
    }
}

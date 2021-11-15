using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Aa
{
   public class DerivedClass : BaseClass
    {
        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}

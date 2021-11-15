using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchuk4
{
    public class BaseClass
    {
        public virtual void Method()
        {
            Console.WriteLine("Method form BaseClass");
        }
        public void NVMethod()
        {
            Console.WriteLine("NVMethod form BaseClass");

        }
    }
}

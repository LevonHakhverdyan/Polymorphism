using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismShevchuk
{
   public class Derived: Base
    {
        protected override void CoreDoWork() { Console.WriteLine("2"); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismShevchuk
{
    public class Base
    {
        public void DoWork() // shablonni metod
        {
            PreDoWork();
            CoreDoWork();

        }
        protected /*virtual*/ void PreDoWork() { Console.WriteLine("0"); }
        protected virtual void CoreDoWork() { Console.WriteLine("1"); }
    }
}

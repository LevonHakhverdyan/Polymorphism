using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
   public class DerivedClass : BaseClass
    {
        public new void DoWork() { WorkField++; }
        public new int WorkField;
        public new int WorkProperty
        {
            get { return 0; }
        }
    }
}

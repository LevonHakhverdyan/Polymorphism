using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    public class BaseClass
    {
        public void DoWork() { WorkField++; }
        public int WorkField;
        public int WorkProperty
        {
            get { return 0; }
        }
    }
}

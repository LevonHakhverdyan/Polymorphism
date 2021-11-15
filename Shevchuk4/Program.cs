using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shevchuk4
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();
            instance.NVMethod();

            //UpCast
            BaseClass instanceUp = instance;
            instanceUp.Method();
            instanceUp.NVMethod();

            // DownCast
            DerivedClass instanceDown = (DerivedClass)instanceUp;
            instanceDown.Method();
            instanceDown.NVMethod();

            Console.ReadKey();

        }
    }
}

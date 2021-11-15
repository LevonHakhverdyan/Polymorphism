using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismShevchuk //NVI - Non-Virtual Interface (Voch virtual interfeys)
{
    class Program
    {
        static void Main(string[] args)
        {
            Base instance = new Derived();
            instance.DoWork();
            Console.ReadKey();
        }
    }
}

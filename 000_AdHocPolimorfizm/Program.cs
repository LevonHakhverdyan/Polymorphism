using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_AdHocPolimorfizm
{
    public class Class1 { public void Method() { Console.WriteLine("Class1"); } }
    public class Class2 { public void Method() { Console.WriteLine("Class2"); } }
    public class Class3 { public void Method() { Console.WriteLine("Class3"); } }


    class Program
    {
        static void Main(string[] args)
        {
            //dynamic instance = new Class1();
            //instance.Method();

            //instance = new Class2();
            //instance.Method();

            //instance = new Class3();
            //instance.Method();

            dynamic[] array = { new Class1(), new Class2(), new Class3() };
            foreach (var item in array)
                item.Method();
            Console.ReadKey();
        }
    }
}

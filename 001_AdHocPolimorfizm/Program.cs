using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_AdHocPolimorfizm
{
    public class Class1 { public void Method() { Console.WriteLine("Class1"); } }
    public class Class2 { public void Method() { Console.WriteLine("Class2"); } }
    public class Class3 { public void Method() { Console.WriteLine("Class3"); } }
    interface IInterface { void Method(); }
    class MyClass1 : Class1, IInterface { }
    class MyClass2 : Class2, IInterface { }
    class MyClass3 : Class3, IInterface { }

    class Program
    {
        static void Main(string[] args)
        {
            IInterface[] array = { new MyClass1(), new MyClass2(), new MyClass3() };
            //for (int i = 0; i < array.Length; i++)
            //    array[i].Method();
            foreach (var item in array)
                item.Method();
            Console.ReadKey();
            {

            }
        }
    }
}

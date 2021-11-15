using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _SealedMethod
{
    class ClassA
    {
        public virtual void Method1() { Console.WriteLine("ClassA.Method1"); }
        public virtual void Method2() { Console.WriteLine("ClassA.Method2"); }
    }
    class ClassB :ClassA
    {
        sealed public override void Method1() { Console.WriteLine("ClassA.Method1"); }
        public override void Method2() { Console.WriteLine("ClassA.Method2"); }
    }
    class ClassC : ClassB
    {
        //sealed public override void Method1() { Console.WriteLine("ClassA.Method1"); }
        public override void Method2() { Console.WriteLine("ClassA.Method2"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

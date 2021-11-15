using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] array = { new Triangle(), new Recktangle(), new Circle() };
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();

            }
            Console.ReadKey();
        }
    }
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shape");
        }
    }
    public class Triangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle");
        }
    }
    public class Recktangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Recktangle");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}

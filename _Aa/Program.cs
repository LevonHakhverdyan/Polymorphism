﻿using _Aa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _As
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            //UpCast
            BaseClass instanceUp = instance as BaseClass;
            if (instanceUp != null)
            instanceUp.Method();

            //DownCast
            DerivedClass instanceDown = instanceUp as DerivedClass;
            instanceDown.Method();

            Console.ReadKey();
           
        }
    }
}

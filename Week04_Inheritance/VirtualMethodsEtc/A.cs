using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04_Inheritance.VirtualMethodsEtc
{
    internal class A
    {
        public int aa=5;
        public A(int x)
        {
            Console.WriteLine("An instance has been created from class A");
        }
        public int a;

        public virtual void M(){

            Console.WriteLine("I am in the Class A");

        }
    }
}

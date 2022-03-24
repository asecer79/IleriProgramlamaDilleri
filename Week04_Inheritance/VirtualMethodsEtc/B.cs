using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04_Inheritance.VirtualMethodsEtc
{
    internal class B : A
    {
        public B(int x):base(x)
        {
            Console.WriteLine("An instance has been created from class B");
        }

        public int b;
        public override void M()
        {
            Console.WriteLine("I am in the Class B");
        }
    }
}

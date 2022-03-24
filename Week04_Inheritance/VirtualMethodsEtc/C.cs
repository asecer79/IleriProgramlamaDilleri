using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04_Inheritance.VirtualMethodsEtc
{
    internal class C:B
    {
        public int aa = 10;

        public C(int x):base(x)
        {
            Console.WriteLine(base.aa+ " An instance has been created from class C" + aa);
        }


        public int c;

        public override void M()
        {
            Console.WriteLine("I am in the Class C");
        }
    }


   


}

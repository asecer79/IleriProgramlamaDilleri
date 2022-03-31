using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05.ClassTypes
{
    class MyClass
    {
        private RegularClass _regularClass = new RegularClass();

        //StaticClass _staticClass = new StaticClass();

        void M1()
        {
            StaticClass.M();

            var x = AbstractClass.b;

            SealedClass sealedClass = new SealedClass();

          

        }

        LongClass _longClass= new LongClass();
        

    }


    partial  class LongClass
    {
        private int x = 5;
        public int A { get; set; }
    }

    partial class LongClass
    {

        public int B { get; set; }
    }

    sealed class SealedClass:B
    {
        public void M1()
        {
            throw new NotImplementedException();
        }
    }

    class B
    {
        
    }

    class RegularClass : AbstractClass
    {
        private static int a;
        public static int P1 { get; set; }

        void M()
        {

        }

        private int ba;
        public override void M1()
        {
            throw new NotImplementedException();
        }
    }

    abstract class AbstractClass
    {
        public static int b;
        public abstract void M1();

        public void M2()
        {
            Console.WriteLine("Concrete");
        }
    }

    interface IInterface
    {
        void M1();
    }
    static class StaticClass
    {
        public static int a { get; set; }
        public static int c;

        public static void M()
        {

        }
    }
}

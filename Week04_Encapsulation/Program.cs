using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A Assembly
namespace Week04_Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }


    public class ABase
    {
        private int aBase_member1;

        public int aBase_member2;

        internal int aBase_member3;

        protected int aBase_member4;

        protected internal int aBase_member5;

        private void ABaseMethod1()
        {
            //private
            aBase_member1 = 0;//possible

            //public
            aBase_member2 = 5;//possible

            //internal
            aBase_member3 = 5;//possible


            //protected
            aBase_member4 = 5;//possible

            //protected internal
            aBase_member5 = 5;//possible
        }
    }

    class ADerived : ABase
    {
        private int aDerived_member1;

        private ABase aBase;

        private void ADerivedMethod1()
        {
            aBase = new ABase();

            //private
            //_aBase.aBase_member1 = 0; //not possible
            //base.aBase_member1 = 5; //not possible

            //public
             aBase.aBase_member2 = 0; //possible
             base.aBase_member2 = 5; //possible

            //internal
            aBase.aBase_member3 = 0; //possible
             base.aBase_member3 = 5; //possible

            //protected
            //aBase.aBase_member4 = 0; //not possible
             base.aBase_member4 = 5; //possible

            //protected internal
            aBase.aBase_member5 = 0; // possible
            base.aBase_member5 = 5; //possible

        }
    }
}

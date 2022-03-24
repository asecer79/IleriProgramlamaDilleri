using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using Week04_Encapsulation;

namespace BAssembly
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }


    class BBase
    {
        private int bBase_member1;

        ABase aBase;

        void ABaseMethod1()
        {
            aBase = new ABase();
            //private
            // aBase.aBase_member1 = 6;//not possible
            
            //public
            aBase.aBase_member2 = 5;//possible

            //internal
            //aBase.aBase_member3 = 0; //not possible

            //protected
            //aBase.aBase_member4 = 0; //not possible

            //protected internal
           // aBase.aBase_member5 = 0; //not possible
        }

    }

    class BDerived : ABase
    {
        private int bDerived_member1;



        void BDerivedMethod1()
        {
            //private
            //  base.aBase_member1 = 0;//not possible

            //public
            base.aBase_member2 = 5; //possible

            //internal
            //base.aBase_member3 = 5; //not possible

            //protected
            base.aBase_member4 = 5; //possible

            //protected internal
            base.aBase_member5 = 5; //possible
        }
    }
}



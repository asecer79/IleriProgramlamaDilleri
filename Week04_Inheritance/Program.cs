using Week04_Inheritance.VirtualMethodsEtc;

namespace Week04_Inheritance
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a.M();
            //B b = new B();
            //b.M();
            C c = new C(5);
            //c.M();

            //WhoAreYou(a);
            //WhoAreYou(b);
            //WhoAreYou(c);
        }


        static void WhoAreYou(A obj)
        {
            obj.M();
        }
    
    }







    //class A
    //{
    //    public A()
    //    {
            
    //    }

    //    public int fieldA;

    //    protected void MethodA()
    //    {

    //    }
    //}

    //class B : A
    //{
    //    //public int fieldA;
    //    public B()
    //    {
    //        MethodA();

    //        this.fieldA = 5;
            
    //        base.fieldA=5;
            
    //    }

    //    protected int fieldB;

    //    public void MethodB()
    //    {

    //    }
    //}

    //class C : B
    //{
    //    public int fieldC;
    //    public C()
    //    {
    //        MethodA();
    //        MethodB();
    //        MethodC();

    //        fieldA = 7;
    //        fieldB = 6;
    //        fieldC = 7;
    //    }

    //    public void MethodC()
    //    {

    //    }
    //}

}


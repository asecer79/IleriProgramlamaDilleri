namespace Week04_Inheritance
{
    
    class Program
    {
        static void Main(string[] args)
        {

        }
    }





    class A
    {
        public A()
        {
            
        }

        public int fieldA;

        protected void MethodA()
        {

        }
    }

    class B : A
    {
        //public int fieldA;
        public B()
        {
            MethodA();

            this.fieldA = 5;
            
            base.fieldA=5;
            
        }

        protected int fieldB;

        public void MethodB()
        {

        }
    }

    class C : B
    {
        public int fieldC;
        public C()
        {
            MethodA();
            MethodB();
            MethodC();

            fieldA = 7;
            fieldB = 6;
            fieldC = 7;
        }

        public void MethodC()
        {

        }
    }

}


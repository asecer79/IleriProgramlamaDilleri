

using Communications.Abstract;
using Communications.Concrete;

namespace Week05
{

    class Program
    {
        static void Main(string[] args)
        {

            //...Dependency Injection 
            //Messenger messenger = new Messenger(new SmsSender());
            //Messenger messenger = new Messenger(new SmsSender());
            //messenger.SendMessage();

            //Print(new A());
            //Print(new B());
            //Print(new C());

            //value types
            MyStruct myStruct;
            myStruct.x = 5;
            Console.WriteLine(myStruct.x);
            ChangeValue(myStruct);
            Console.WriteLine(myStruct.x);

         
            //reference types
            MyClass myClass=new MyClass();
            myClass.x = 5;
            Console.WriteLine(myClass.x);
            ChangeReferenceValue(myClass);
            Console.WriteLine(myClass.x);



        }
        //static void Print(IInterface1 obj)
        //{
        //    obj.M();
        //}

        //static void Print(MyBase obj)
        //{
        //    obj.M();
        //}
        //
        static void ChangeValue(MyStruct obj)
        {
            obj.x *= obj.x;
        }

        static void ChangeReferenceValue(MyClass obj)
        {
            obj.x *= obj.x;
        }
    }



    struct MyStruct
    {
        public int x;
    }

    class MyClass
    {
        public int x;
    }

    class MyBase
    {


        public virtual void M()
        {
            Console.WriteLine("I am base");
        }
    }

    class A : MyBase
    {
        public override void M()
        {
            Console.WriteLine("I am A");
        }
    }

    class B : MyBase
    {
        public override void M()
        {
            Console.WriteLine("I am B");
        }
    }

    class C : MyBase
    {
        public override void M()
        {
            Console.WriteLine("I am C");
        }
    }

    //interface IInterface1
    //{
    //    void M();
    //}

    //class A : IInterface1
    //{
    //    public void M()
    //    {
    //        Console.WriteLine("I am A");
    //    }
    //}

    //class B : IInterface1
    //{
    //    public void M()
    //    {
    //        Console.WriteLine("I am B");
    //    }
    //}

    //class C : IInterface1
    //{
    //    public void M()
    //    {
    //        Console.WriteLine("I am C");
    //    }
    //}


    class Messenger
    {
        // private readonly IMessage _message;
        private MessageManager _message;

        public Messenger(MessageManager message)
        {
            _message = message;
        }
        public void SendMessage()
        {
            _message.SendMessage();
        }

        public void GetMessage()
        {
            _message.GetMessage();
        }
    }



    //1st example
    interface ICalculus
    {
        double TrapezoidRule(double[,] fx, double a, double b);

    }

    interface IStatistics
    {
        double StdDev(double[] arr);
        double Avg(double[] arr);
        double Min(double[] arr);
        double Max(double[] arr);
    }

    interface IMath : IStatistics, ICalculus
    {
        double Sum(int x, int y);
        double Subtract(int x, int y);
        double Division(int x, int y);
        double Product(int x, int y);
        double Exponent(double x, int n);
    }

    class MyMath : IMath
    {
        public double Sum(int x, int y)
        {
            return x + y;
        }

        public double Subtract(int x, int y)
        {
            return x - y;
        }

        public double Division(int x, int y)
        {
            return x / (double)y;
        }

        public double Product(int x, int y)
        {
            return x * y;
        }

        public double Exponent(double x, int n)
        {
            var res = 1.0;

            for (int i = 1; i <= n; i++)
                res *= res;
            return res;
        }

        public double StdDev(double[] arr)
        {
            throw new NotImplementedException();
        }

        public double Avg(double[] arr)
        {
            throw new NotImplementedException();
        }

        public double Min(double[] arr)
        {
            throw new NotImplementedException();
        }

        public double Max(double[] arr)
        {
            throw new NotImplementedException();
        }

        public double TrapezoidRule(double[,] fx, double a, double b)
        {
            throw new NotImplementedException();
        }
    }





}



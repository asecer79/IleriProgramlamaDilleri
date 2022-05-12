using System.Diagnostics.CodeAnalysis;

namespace Week10
{
    public delegate void EventHandler(object sender, EventArgs args);

    public delegate int MathProcessInt(int a, int b);
    //public delegate double MathProcess(double a, double b);
    //public delegate T MathProcess<T>(T a, T b);
    //public delegate T MathProcess<T>(T a, T b);

    class Program
    {
        static void Main(string[] args)
        {
            //MathProcess invocations = Sum;
            //invocations += Subtract;
            //invocations += Divide;
            //invocations += Product;

            //invocations.Invoke(1,2);

            //DoProcess(Sum,1,2);
            //DoProcess(Subtract, 1, 2);
            //DoProcess(Divide, 1, 2);
            //DoProcess(Product, 1, 2);

            //SelectAppropriateMethod(1)(1, 2);

            //DoProcess(SelectAppropriateMethod(1), 1, 2);

            //Action<int, int> m = (int a, int b) =>
            // {
            //     int x = 5;
            //     Console.WriteLine(x * x);
            // };

            //Func<double, double, double> Trapezoidal = (a, b) =>
            //{
            //    ///
            //    return 1;
            //};

            //Func<int, int, int> Trapezoidal2 = (a, b) =>
            //{
            //    ///
            //    return 2;
            //};

            ////DoProcess(Trapezoidal, 1, 3);

            //DoProcess((a, b) => { return a + b; }, 1, 3);
            //DoProcess(Trapezoidal, 1, 3);
            //DoProcess(Trapezoidal2, 1, 3);

            //var s1 = (int a, int b) =>
            //{
            //    return a + b;
            //};

            //Func<int, int, int> s2 = (int a, int b) =>
            //{
            //    return a + b;
            //};

            //MathProcessInt s3 = (int a, int b) =>
            //{
            //    return a + b;
            //};


            DatabaseBackupHelper backupHelper = new DatabaseBackupHelper();

            backupHelper.BackupCompleted += BackupHelper_BackupCompleted;
            backupHelper.BackupCompleted += BackupHelper_BackupCompleted1;
            backupHelper.BackupStarted += BackupHelper_BackupStarted;

            backupHelper.BackupDatabase();
            backupHelper.BackupCompleted -= BackupHelper_BackupCompleted1;

        }

        private static void BackupHelper_BackupCompleted1(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }

        private static void BackupHelper_BackupStarted(object sender, EventArgs args)
        {
            //
            Console.WriteLine("Send email Started");
        }

        private static void BackupHelper_BackupCompleted(object sender, EventArgs args)
        {
            //
            Console.WriteLine("Send email Finished");
        }

        static void DoProcess<T>(Func<T, T, T> method, T a, T b)
        {
            Console.WriteLine(method(a, b));

        }


        //static void DoProcess(MathProcess<int> method, int a, int b)
        //{
        //    Console.WriteLine(method(a, b));

        //}

        //static MathProcess<double> SelectAppropriateMethod(int checkPoint)
        //{

        //    if (checkPoint == 1)
        //    {
        //        return Sum;
        //    }
        //    if (checkPoint == 2)
        //    {
        //        return Divide;
        //    }

        //    return Product;

        //}

        static double Sum(double a, double b)
        {
            //Console.WriteLine("Sum");
            return a + b;
        }

        static int Sum(int a, int b)
        {
            //Console.WriteLine("Sum");
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            //Console.WriteLine("Subtract");
            return a - b;
        }

        static int Divide(int a, int b)
        {
            //Console.WriteLine("Divide");
            return a / b;
        }

        static int Product(int a, int b)
        {
            // Console.WriteLine("Product");
            return a * b;
        }

        static double Divide(double a, double b)
        {
            //Console.WriteLine("Divide");
            return a / b;
        }

        static double Product(double a, double b)
        {
            // Console.WriteLine("Product");
            return a * b;
        }
    }


    class DatabaseBackupHelper
    {
        public event EventHandler BackupCompleted;
        public event EventHandler BackupStarted;


        public void BackupDatabase()
        {
            FireBackupStarted();
            Console.WriteLine("Backup-Started.....");
            Thread.Sleep(2000);
            Console.WriteLine("Backup-In Progress.....");
            Thread.Sleep(2000);
            Console.WriteLine("Backup Completed.....");
            FireBackupCompleted();
        }

        //delegates invoke
        //events raise

        private void FireBackupCompleted()
        {
            if (BackupCompleted != null)
                BackupCompleted(this, EventArgs.Empty);
        }
        private void FireBackupStarted()
        {
            if (BackupStarted != null)
                BackupStarted(this, EventArgs.Empty);
        }
    }
};



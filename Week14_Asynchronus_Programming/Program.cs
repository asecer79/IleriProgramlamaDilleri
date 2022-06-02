
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Week14_Asynchronus_Programming
{
    public class Program
    {

        static void Main(string[] args)
        {



            //Account account = new Account("Aydın SEÇER", 1000);

            //account.ShowBalance();

            //for (int j = 0; j < 10; j++)
            //{

            //    for (int i = 0; i < 200; i++)
            //    {
            //        new Thread(account.WithdrawMoney).Start(100);

            //        new Thread(account.DepositMoney).Start(100);

            //        //account.WithdrawMoney(100);
            //        //account.DepositMoney(100);

            //    }

            //    Thread.Sleep(3000);
            //    account.ShowBalance();
            //}

            ////   Thread.Sleep(3000);

            //Console.ReadLine();



            //for (int i = 0; i < 5; i++)
            //{
            //    M1();
            //    M2();
            //}

            //Console.WriteLine("Start");

            ////Parallel.For(0, 50, (i) =>
            ////{
            ////    M1();
            ////    M2();
            ////});

            //Parallel.Invoke(M1,M2);

            //Console.WriteLine("End");

            //Thread.Sleep(2000);


            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});

            //Task.Run(() =>
            //{
            //    M1();
            //});

            M1().Wait();
       
            Console.WriteLine("Main ends");

            Thread.Sleep(2000);

            Account a = new Account("", 1);
        }



        static async Task M1()
        {
            await Task.Run(() =>
             {
                 Thread.Sleep(2000);
                 Console.WriteLine("M1");
                
             }); 
            
           // return "Finished: M1";
        }
        static void M2()
        {
            Thread.Sleep(10);
            Console.WriteLine("M2");
        }
    }


    [Obsolete("Iptal edilecek")]
    class Account
    {
        private Mutex _mutex;


        public Account(string owner, decimal balance)
        {
            Balance = balance;
            Owner = owner;
            _mutex = new Mutex();

        }
        private string Owner { get; set; }
        private decimal Balance { get; set; }



        public void WithdrawMoney(object amount)
        {
            _mutex.WaitOne();
            Balance -= Convert.ToDecimal(amount);
            _mutex.ReleaseMutex();

        }

        public void DepositMoney(object amount)
        {
            _mutex.WaitOne();
            Balance += Convert.ToDecimal(amount);
            _mutex.ReleaseMutex();

        }

        //object o = new object();


        //public void WithdrawMoney(object amount)
        //{
        //    lock (o)
        //    {
        //        Balance -= Convert.ToDecimal(amount);
        //    }

        //}

        //public void DepositMoney(object amount)
        //{
        //    lock (o)
        //    {
        //        Balance += Convert.ToDecimal(amount);
        //    }
        //}

        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
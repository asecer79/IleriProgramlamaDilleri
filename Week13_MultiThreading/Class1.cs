namespace Week13_MultiThreading
{
    public class Class1
    {
        static void Main(string[] args)
        {





            //Console.WriteLine("Main starts");

            //Thread thread1 = new Thread(Print1); //async
            //thread1.Priority = ThreadPriority.Lowest;
            //thread1.IsBackground = true;
            //thread1.Start("Background");
            ////thread1.Join(5000);

            //Thread thread2 = new Thread(Print2); //async
            //thread2.IsBackground = true;
            //thread2.Start("Background");

            ////Thread.CurrentThread.Join(7000);
            ////Thread.Sleep(10000);
            //Console.WriteLine("Main terminates");

            ThreadPool.SetMinThreads(2, 2);
            ThreadPool.SetMaxThreads(32, 4);

            WaitCallback wcb = new WaitCallback(Login);
            

            for (int i = 0; i < 10000; i++)
            {
                ThreadPool.QueueUserWorkItem(wcb, $"user-{i} logged in");
            }

            Console.ReadLine();
        }
        static void Login(object userName)
        {
            // Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

             Thread.Sleep(2000);

            Console.WriteLine(userName);
        }

        static void Print1(object message)
        {
            // Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(1000);

            Console.WriteLine(message);
        }
        static void Print2(object message)
        {
            // Console.WriteLine(Thread.CurrentThread.ManagedThreadId);


             Thread.Sleep(3000);

            Console.WriteLine(message);
        }
    }
}
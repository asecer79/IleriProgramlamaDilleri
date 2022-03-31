using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Communications.Abstract;

namespace Communications.Concrete
{
    //public class EmailSender:IMessage
    //{
    //    public bool SendMessage()
    //    {
    //        Console.WriteLine("Email sent...");
    //        //....
    //        return true;
    //    }

    //    public string GetMessage()
    //    {
    //        Console.WriteLine("Email received...");
    //        return "";
    //    }
    //}

    public class EmailSender:MessageManager
    {
        public override bool SendMessage()
        {
            Console.WriteLine("Email sent...");
            return true;
        }

        public override string GetMessage()
        {
            Console.WriteLine("Email received...");
            return "";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Communications.Abstract;

namespace Communications.Concrete
{
    //public class SmsSender:IMessage
    //{
    //    public bool SendMessage()
    //    {
    //        Console.WriteLine("Sms sent...");
    //        //....
    //        return true;
    //    }

    //    public string GetMessage()
    //    {
    //        Console.WriteLine("Sms received...");
    //        return "";
    //    }
    //}

    public class SmsSender : MessageManager
    {
        public sealed override  string GetMessageType(int mtype)
        {
            if (mtype == 1)
                return "DD";
            if (mtype == 2)
                return "ZZ";

            return "Error";
        }

        public override bool SendMessage()
        {
            Console.WriteLine("Sms sent...");
            //....
            return true;
        }

        public override string GetMessage()
        {
            Console.WriteLine("Sms received...");
            return "";
        }
    }

    class Test:SmsSender
    {
        public Test()
        {
            GetMessageType(1);
        }
    }
}

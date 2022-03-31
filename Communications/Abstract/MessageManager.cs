using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Communications.Abstract
{
    public abstract class MessageManager
    {
          public abstract bool SendMessage();
          public abstract string GetMessage();

          public virtual string GetMessageType(int mtype)
          {
              if (mtype==1)
                  return "SMS";
              if (mtype == 2)
                  return "EMail";

              return "Error";
          }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05.Structs
{
    class Test
    {
        void M()
        {
            MyStruct myStruct = new MyStruct(1,2);
            myStruct.A = 6;
            myStruct.x = 3;
            
        }
    }

    class MyClass
    {
    
        public int A { get; set; }
        public int x=0;

        public void M1()
        {

        }
    }

    interface IInterface
    {
        void C();
    }

    struct MyStruct2
    {
        
    }
    struct MyStruct
    {
        public MyStruct(int x1, int y1)
        {
            x = x1;
            A = y1;
        }

        public int A { get; set; }
        public int x;

        public void M1()
        {

        }

        public void C()
        {
            throw new NotImplementedException();
        }
    }
}

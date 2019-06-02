using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ
{
    class MyInteger : MyType
    {
        public MyInteger(object value) : base (value)
        {
            
        }

        public static MyType operator +(MyInteger num1, MyInteger num2)
        {
            return new MyType((int)num1.value + (int)num2.value);
        }

        public static MyType operator -(MyInteger num1, MyInteger num2)
        {
            return new MyType((int)num1.value - (int)num2.value);
        }

    }
}

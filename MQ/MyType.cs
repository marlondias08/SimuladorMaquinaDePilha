using System;
using System.Collections.Generic;
using System.Collections;

namespace MQ
{
    public class MyType
    {
        public object value { get; set; }

        public MyType(object value)
        {
            if (value is MyType)
                this.value = int.Parse(value.ToString());
            else
                this.value = value;   
        }

        public override string ToString()
        {
            return ""+value;
        }
    }
}
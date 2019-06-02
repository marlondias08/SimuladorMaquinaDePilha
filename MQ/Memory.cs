using System;
using System.Collections.Generic;
using System.Collections;

namespace MQ
{
    public class Memory
    {
        private Dictionary<string, MyType> memory = new Dictionary<string, MyType>();

        public void store (string index, MyType value)
        {
            memory[index] = value;
        }

        public MyType load (string index)
        {
            return memory [index];
        }
    }


}
using System;
using System.Collections.Generic;
using System.Collections;

namespace MQ
{
    public abstract class Instruct
    {
        protected Dictionary<string, int> labels;
        protected Memory memory;
        protected MyStack stack;
        public string argument;

        public Instruct(Memory memory, MyStack stack, Dictionary<string, int> labels, string argument)
        {
            this.memory = memory;
            this.stack = stack;
            this.labels = labels;
            this.argument = argument;
        }

        public abstract int execute(int count);

    }
}
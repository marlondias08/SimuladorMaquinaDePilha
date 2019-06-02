using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ
{
    class Push : Instruct
    {
        public Push(Memory memory, MyStack stack, Dictionary<string, int> labels, string argument) : base(memory, stack, labels, argument)
        {
        }

        public override int execute(int count)
        {
            int test;
            if (int.TryParse(argument, out test))
            {
                stack.push(new MyType(test));
            }
            else
                stack.push(new MyType(bool.Parse(argument)));
            return count + 1;
        }
    }
}
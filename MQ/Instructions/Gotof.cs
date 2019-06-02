using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ
{
    class Gotof: Instruct
    {
        public Gotof(Memory memory, MyStack stack, Dictionary<string, int> labels, string argument) : base(memory, stack, labels, argument)
        {
        }

        public override int execute(int count)
        {
            object value = stack.pop().value;
            if (value is bool)
            {
                if (!(bool)value)
                {
                    return labels[argument] + 1;
                }
            }
            return count +1;
        }
    }
}


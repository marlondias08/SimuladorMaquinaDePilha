using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ
{
    class Load : Instruct
    {
        public Load(Memory memory, MyStack stack, Dictionary<string, int> labels, string argument) : base(memory, stack, labels, argument)
        {
        }

        public override int execute(int count)
        {
            stack.push(memory.load(argument));
            return count +1;
        }
    }
}

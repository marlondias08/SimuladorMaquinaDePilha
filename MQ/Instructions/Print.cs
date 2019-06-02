using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ
{
    class Print : Instruct
    {
        public Print(Memory memory, MyStack stack, Dictionary<string, int> labels, string argument) : base(memory, stack, labels, argument)
        {
        }

        public override int execute(int count)
        {
            Console.WriteLine("\nThe result is: {0}\n",stack.pop());
            return count +1;
        }
    }
}


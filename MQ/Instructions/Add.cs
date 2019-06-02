using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ
{
    class Add : Instruct
    {
        public Add(Memory memory, MyStack stack, Dictionary<string, int> labels, string argument) : base(memory, stack, labels, argument)
        {
        }

        public override int execute(int count)
        {
            MyInteger num1 = new MyInteger(stack.pop());
            MyInteger num2 = new MyInteger(stack.pop());
            stack.push(num1 + num2);
            return count + 1;
        }
    }
}

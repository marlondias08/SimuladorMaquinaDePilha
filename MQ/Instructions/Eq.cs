using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ
{
    class Eq : Instruct
    {
        public Eq(Memory memory, MyStack stack, Dictionary<string, int> labels, string argument) : base(memory, stack, labels, argument)
        {
        }

        public override int execute(int count)
        {
            MyInteger num1 = new MyInteger(stack.pop());
            MyInteger num2 = new MyInteger(stack.pop());
            if (num1.value.Equals(num2.value))
                stack.push(new MyType(true));
            else
                stack.push(new MyType(false));
            return count + 1;
        }
    }
}

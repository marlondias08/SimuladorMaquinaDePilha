using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ
{
    class Read : Instruct
    {
        public Read(Memory memory, MyStack stack, Dictionary<string, int> labels, string argument) : base(memory, stack, labels, argument)
        {
        }

        public override int execute(int count)
        {
            Console.WriteLine("Enter a positive integer: ");
            try
            {
                int test = int.Parse(Console.ReadLine());
                if (test >= 0)
                {
                    MyType value = new MyType(test);
                    stack.push(value);
                    return count + 1;
                }
                Console.WriteLine("Only positive integer.\n");
                return count;
            }
            catch (Exception)
            {
                Console.WriteLine("Only positive integer.\n");
                return count;
            }
        }
    }
}


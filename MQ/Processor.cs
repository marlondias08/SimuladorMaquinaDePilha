using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MQ
{
    class Processor
    {
        private Memory memory = new Memory();
        private MyStack stack = new MyStack();
        private int count = 0;
        private List<Instruct> instructions = new List<Instruct>();
        private Dictionary<string, int> labels = new Dictionary<string, int>();

        public Processor(List<string> instructString)
        {
            foreach (string i in instructString)
            {
                instructions.Add(InstructParser.parse(i, memory, stack, labels));
            }

            process();

            loop();
        }

        void process()
        {
            for (int i = 0; i < instructions.Count; i++)
            {
                if (instructions[i] is Label)
                {
                    labels.Add(instructions[i].argument, i);
                }
            }
        }

        void loop()
        {
            Instruct i = null;
            do
            {
                i = instructions[count];
                count = i.execute(count);
            }
            while (!(i is End));
        }


    }
}

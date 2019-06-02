using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ
{
    class InstructParser
    { 
        public static Instruct parse(string i, Memory memory, MyStack stack, Dictionary<string, int> labels)
        {
            string[] parts = i.Split(' ');
            string attribute = null;
            if (parts.Length == 2)
            {
                attribute = parts[1];
            }

            var instance = Activator.CreateInstance(Type.GetType("MQ." + parts[0]), memory, stack, labels, attribute);
            return (Instruct)instance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Security.Permissions;

namespace MQ
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> instructions = new List<string>();
            //Arquivo para leitura da multiplicação.
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "multiplication.txt"));

        Menu:
            Console.WriteLine("Choose an option:\n1 - Multiplication\n2 - Even or odd\n3 - Exit");

            char choice = Console.ReadKey(true).KeyChar;
            while (Console.KeyAvailable) choice = Console.ReadKey(true).KeyChar;

            {
                switch (choice)
                {

                    case '1':

                        Console.WriteLine("\n1 - Multiplication\n");

                        foreach (string line in lines)
                        {
                            instructions.Add(line);
                        }
                        
                        new Processor(instructions);
                        instructions.Clear();
                        goto Menu;

                    case '2':

                        Console.WriteLine("\n2 - Even or odd\n");
                        //Programa pra testar se é par ou ímpar.

                        instructions.Add("Read");
                        instructions.Add("Store A");
                        instructions.Add("Label Loop");
                        instructions.Add("Push 2");
                        instructions.Add("Load A");
                        instructions.Add("Sub");
                        instructions.Add("Store A");
                        instructions.Add("Push 1");
                        instructions.Add("Load A");
                        instructions.Add("Le");
                        instructions.Add("Gotof Loop");
                        instructions.Add("Push 0");
                        instructions.Add("Load A");
                        instructions.Add("Eq");
                        instructions.Add("Gotof Done0");
                        instructions.Add("Push 1");
                        instructions.Add("Push true");
                        instructions.Add("Goto Done1");
                        instructions.Add("Label Done0");
                        instructions.Add("Push 0");
                        instructions.Add("Label Done1");
                        instructions.Add("Print");
                        instructions.Add("End");
                        Console.WriteLine("The result will be 1 if the number is even or 0 if the number is odd.\n");

                        new Processor(instructions);
                        instructions.Clear();
                        goto Menu;

                    case '3':

                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("\nChoose 1, 2 or 3.\n");
                        goto Menu;

                }
            }
        } 
    }
}

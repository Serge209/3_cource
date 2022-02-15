using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static int Main(string[] args)
        {
            // Вывести пользователю простое сообщение
            Console.WriteLine("My first App");
            Console.WriteLine("Hello world");
            //Обработать любые входные аргументы
            Console.WriteLine(args.Length);
            // Обработать любые входные аргументы,
            foreach (string arg in args)
                Console.WriteLine("Arg: {0}", arg);
            Console.ReadLine();
            return -1;
        }
    }
}

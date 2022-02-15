using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp14
{
    class Program
    {
        static int Main(string[] args)
        {
            ShowEnvironmentDetails();
            Console.ReadLine();
            return -1;
        }
        static void ShowEnvironmentDetails()
        {
            //Вывести информацию о дисковых устройствах
            //Данной машины и другие интересные детали
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive); //логические устройства
                Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount); // Количество процессоров
                Console.WriteLine(".NET Version: {0}", Environment.Version); ;//Версия платформы NET
                Console.WriteLine("OS:{0}", Environment.OSVersion);//Версия операционной системы
            }

           
        }
    }
}


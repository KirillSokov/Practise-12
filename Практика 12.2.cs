using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_12._2
{
    internal class ProgramConfig
    {
        public const string Version = "6.7";
        public const string Name = "Иван Золо";

        public static void Display()
        {
            Console.WriteLine($"Версия: {Version}");
            Console.WriteLine($"Разработчик: {Name}");

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramConfig.Display();

        }
    }

}

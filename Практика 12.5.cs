using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_12._5
{
    internal class Settings
    {
        private static readonly string configur;

        static Settings()
        {
            configur = @"Users\1\source\repos\Practise 12.5\bin\Debug\Practise 12.5.exe";
        }

        public static void Display()
        {
            Console.WriteLine("Путь к файлу: " + configur);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.Display();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hello World!");
            Console.ResetColor();
        }
    }
}

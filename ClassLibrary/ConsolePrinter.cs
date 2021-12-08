using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ConsolePrinter : IPrinter
    {
        ConsoleColor color;

        public ConsolePrinter(ConsoleColor color)
        {
            this.color = color;
        }

        public void SetConsoleColor(ConsoleColor color)
        {
            this.color = color;
        }

        public void Print(IPrinter printer, Weather weather)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(weather.ToString());
            Console.ResetColor();
        }

    }
}

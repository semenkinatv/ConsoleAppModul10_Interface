using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppModul10_Interface
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }

        public void Event(string message)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }
    }
}

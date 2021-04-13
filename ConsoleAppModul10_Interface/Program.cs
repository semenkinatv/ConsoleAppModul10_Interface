using System;

namespace ConsoleAppModul10_Interface
{
    class Program
    {
        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {  
            int[] num = new int[2] { 0, 0 };

            Logger = new Logger();
            
            ReadNumber readNumber = new ReadNumber(Logger);
            num = readNumber.ReadNum();

            Console.WriteLine();

            BaseCalculator baseCalculator = new BaseCalculator(Logger);
            ((ICalculator)baseCalculator).Solve(num);

            Console.ReadKey();
        }
    }

    public interface ICalculator
    {
        void Solve(int[] num);
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}

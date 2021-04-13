using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppModul10_Interface
{
    public class BaseCalculator : ICalculator
    {
        ILogger Logger { get; }
        public BaseCalculator(ILogger logger)
        {
            Logger = logger;
        }

        public void Solve(int[] num)
        {
            int rez;
            rez = num[0] + num[1];
            Logger.Event($"Сумма чисел {num[0]} и {num[1]} = {rez}");
            
            
        }
    }
}

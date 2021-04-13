using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppModul10_Interface
{
    public class ReadNumber 
    {
        ILogger Logger { get; }
        public ReadNumber(ILogger logger)
        {
            Logger = logger;
        }

        public int[] ReadNum()
        {
            int[] num = new int[2] { 0, 0 };
            int i = 0;
            
            while (i != 2)
            {
                Console.WriteLine();
                Console.Write("Введите число: ");
                string text = Console.ReadLine();

                try
                {
                    int number = Int32.Parse(text);
                    num[i] = number;
                    i++;
                }

                catch (Exception ex)
                {
                    Logger.Error("Не удалось распознать число, попробуйте еще раз.");
                    Logger.Error(ex.Message);
                }
                finally
                { }
            }
            return num;
            
        }


    }
}

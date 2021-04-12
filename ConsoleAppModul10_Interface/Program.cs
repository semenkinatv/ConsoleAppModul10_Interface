using System;

namespace ConsoleAppModul10_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[2] { 0,0};
            int i = 0;
            int num1;
            int num2;
            Console.WriteLine("Задание 1.");
            
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
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                    Console.WriteLine(ex.Message);
                }
                finally
                { }
            }
            num1 = num[0];
            num2 = num[1];
           
            BaseCalculator baseCalculator = new BaseCalculator();
            ((ICalculator)baseCalculator).Solve(num1, num2);

            Console.ReadKey();
        }
    }

    public interface ICalculator
    { 
        void Solve(int num1, int num2);
    }

    public class BaseCalculator : ICalculator
    {  
        public void Solve(int num1, int num2)
        {   int rez;
            rez = num1 + num2;
            Console.WriteLine();
            Console.WriteLine($"Сумма чисел {num1} и {num2} = {rez}");
        }
    }
}

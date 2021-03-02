using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение!");
            bool nach = double.TryParse(Console.ReadLine(), out double nachD);
            if (!nach)
            {
                Console.WriteLine("Введено не число, программа завершена!");
                return; //Переделать в цикл while
            }

            Calc calc = new Calc(nachD);
            while (true)
            {
                Console.WriteLine("Введите один из типов операции: \"+\", \"-\", \"/\", \"*\".");
                Console.WriteLine("Нажмите соответствующий символ и нажмите  Enter.");
                String oper = Console.ReadLine();
            }
        }
    }
}

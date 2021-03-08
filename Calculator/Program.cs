using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение!");
            bool nach = false;
            double nachD = 0;
            do
            {
                nach = double.TryParse(Console.ReadLine(), out nachD);
                if (!nach)
                {
                    Console.WriteLine("Введено не число, введите число!");
                }
                //Переделать в цикл while
            }
            while (!nach);


            Calc calc = new Calc(nachD);
            while (true)
            {
                Console.WriteLine("Введите один из типов операции: \"+\", \"-\", \"/\", \"*\", \"C\".");
                Console.WriteLine("Нажмите соответствующий символ и нажмите  Enter.");
                String oper = Console.ReadLine().ToUpper();
                bool operandB = false;
                double operandD = 0;
                if (oper != "C")
                {
                    do
                    {
                        Console.WriteLine("Введите число для операции:");
                        operandB = double.TryParse(Console.ReadLine(), out operandD);
                        if (!operandB)
                        {
                            Console.WriteLine("Вы ввели не число");
                        }
                    }
                    while (!operandB);
                }


                switch (oper)
                {
                    case "-":
                        calc.Minus(operandD);
                        break;
                    case "+":
                        calc.Plus(operandD);
                        break;
                    case "/":
                        calc.Divide(operandD);
                        break;
                    case "*":
                        calc.Multi(operandD);
                        break;
                    case "C":
                        calc.Clear();
                        break;
                    default:
                        Console.WriteLine("Операция отсутвует!");
                        break;
                }

                Console.WriteLine($"Ответ = {calc.State}");

            }
        }
    }
}

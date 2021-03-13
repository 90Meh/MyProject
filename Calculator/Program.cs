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


            CalcInteger calc = new CalcInteger(nachD);
            while (true)
            {
                Console.WriteLine($"Введите один из типов операции: {string.Join(", ", Calc.AvailableOperations())}");  //Join ?
                Console.WriteLine("Нажмите соответствующий символ и нажмите  Enter.");
                String oper = Console.ReadLine().ToUpper();
                bool operandB = false;
                double operandD = 0;
                if (oper != "C" && oper != "MS" && oper != "MR" && oper != "MC" && oper != "M+" && oper != "M-")
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
                    //case "MS":
                    //    calc.MemorySave();
                    //    break;
                    //case "MR":
                    //    calc.MemoryRecord();
                    //    break;
                    //case "MC":
                    //    calc.MemoryClear();
                    //    break;
                    //case "M+":
                    //    calc.MemoryPlus();
                    //    break;
                    //case "M-":
                    //    calc.MemoryMinus();
                    //    break;

                    default:
                        Console.WriteLine("Операция отсутвует!");
                        break;
                }

                Console.WriteLine($"Ответ = {calc.State}");

            }
        }


    }
}

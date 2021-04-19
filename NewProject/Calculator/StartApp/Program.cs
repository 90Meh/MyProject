using CalcInterface;
using System;
using SimpleCalc;
using System.Collections.Generic;

namespace StartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите свой калькулятор!");
            Console.WriteLine(" 1. SimpleCalc");
            Console.WriteLine(" 2. CalcWithMemory");
            Console.WriteLine(" 3. CalcAngle");
            Console.WriteLine(" 4. SimpleEventCalc");
            Console.WriteLine(" 5. CalcRound");
            Console.WriteLine(" 6. DelegateCalculator(power)");
            Console.WriteLine(" 7. DelegateCalculator(SQRT)");
            Console.WriteLine(" 8. DelegateCalculator(Lambda10)");
            Console.WriteLine(" 9. DelegateCalculator(Lambda20)");
            Console.WriteLine("10. ProgramCalc");

            string choose = Console.ReadLine();
            ICalc calc;
            switch (choose)
            {
                case "1":
                    calc = new SimpleCalc.SimpleCalc();
                    break;
                case "2":
                    calc = new CalcMem.CalcWithMemory();
                    break;
                case "3":
                    calc = new CalcAngle.CalcSCTG();
                    break;
                case "4":
                    calc = new SimpleCalc.SimpleEventCalc();
                    break;
                case "5":
                    calc = new CalcRound.Round();
                    break;
                case "6":
                    calc = new DelegateCalculator.DelegateCalc(Math.Pow);
                    break;
                case "7":
                    calc = new DelegateCalculator.DelegateCalc(SQRT);
                    break;
                case "8":
                    calc = new DelegateCalculator.DelegateCalc((o1, o2) => o1 + o2 + 10);   //лямбда выражение Анонимная функция в скобках
                    break;
                case "9":
                    calc = new DelegateCalculator.DelegateCalc((o1, o2) =>
                    {
                        return o1 + o2 + 20;
                    });    //лямбда выражение (с телом) Анонимная функция в скобках
                    break;
                case "10":
                    var ops = new Dictionary<string, Func<double, double, double>>();
                    ops.Add("P", Power);
                    ops.Add("S", SQRT);
                    ops.Add("L1", (o1,o2) => o1+o2 +10);
                    calc = new DelegateCalculator.ProgramCalc(ops);
                    break;
                default:
                    Console.WriteLine("Нет доступного калькулятора!");
                    return;
            }

            //CalcService service = new CalcService(calc);
            //service.Start();

            new CalcService(calc).Start();
        }

        static double Power(double operand, double power)
        {
            return Math.Pow(operand, power);
        }

        static double SQRT(double operand, double sqrt)
        {
            return Math.Pow(operand, 1.0/sqrt);
        }
    }
}

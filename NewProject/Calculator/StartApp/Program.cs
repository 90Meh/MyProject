﻿using CalcInterface;
using System;
using SimpleCalc;

namespace StartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите свой калькулятор!");
            Console.WriteLine(" 1. SimpleCalc");
            string choose = Console.ReadLine();
            ICalc calc;
            switch (choose)
            {
                case "1":
                    calc = new SimpleCalc.SimpleCalc();
                    break;
                default:
                    Console.WriteLine("Нет доступного калькулятора!");
                    return;
            }

            //CalcService service = new CalcService(calc);
            //service.Start();

            new CalcService(calc).Start();
        }
    }
}

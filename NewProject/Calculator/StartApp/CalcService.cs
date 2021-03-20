using CalcInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartApp
{
    class CalcService
    {
        private readonly ICalc _calc;
        public CalcService(ICalc calc)
        {
            _calc = calc;
        }

        public void Start()
        {
            Console.WriteLine($"Доступные операции: {string.Join(", ", _calc.GetAvailableOperations())}");
            while (true)
            {
                Console.WriteLine("Ведите зачение!");
                double znach;
                bool parsed;
                do
                {
                    parsed = double.TryParse(Console.ReadLine(), out znach);
                    if (!parsed)
                    {
                        Console.WriteLine("Введено не число, введите число!");
                    }

                }
                while (!parsed);
                _calc.SetOperand(znach);

                Console.WriteLine("Выберете операцию!");
                string oper = Console.ReadLine();
                _calc.SetOperation(oper);
                Console.WriteLine($"Текущее значение = {_calc.State}");
                
            }

        }
    }
}

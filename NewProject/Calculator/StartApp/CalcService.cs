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
                try
                {

                    bool showState = false;

                    if (_calc.NextStep == StepType.Operation)
                    {
                        Console.WriteLine("Выберете операцию!");
                        string oper = Console.ReadLine();
                        showState = _calc.SetOperation(oper);

                    }
                    else
                    {
                        double znach;
                        bool parsed;
                        do
                        {
                            Console.WriteLine("Ведите зачение!");
                            parsed = double.TryParse(Console.ReadLine(), out znach);
                            if (!parsed)
                            {
                                Console.WriteLine("Введено не число, введите число!");
                            }

                        }
                        while (!parsed);
                        showState = _calc.SetOperand(znach);
                    }

                    if (showState)
                    {
                        Console.WriteLine($"Текущее значение = {_calc.State}");

                        IMemCalc mcalc = _calc as IMemCalc;   //Возвращает null при неудачном преобразовании.
                        // if (_calc is IMemCalc && ((IMemCalc)_calc).MemState)  //Проверка на реализацию определённого типа.
                        if (_calc is IMemCalc memCalc && memCalc.MemState)
                        {
                            Console.WriteLine("В памяти хранится значение!");
                        }
                    }


                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на ноль невозможно!");
                }
                catch (WrongOperationException)
                {
                    Console.WriteLine("Выбрана недоступная операция!");
                }

            }

        }
    }
}

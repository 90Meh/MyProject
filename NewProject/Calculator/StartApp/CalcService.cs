using CalcInterface;
using CalcRound;
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
        private bool StateRound = false;
        public CalcService(ICalc calc)
        {
            _calc = calc;
        }

        public void Start()
        {
            Console.WriteLine($"Доступные операции: {string.Join(", ", _calc.GetAvailableOperations())}");
            if (_calc is IEventCalc eventCalc)
            {
                eventCalc.StateChanged += EventCalc_StateChanged; //метод внутри calcservice
            }

            while (true)
            {
                try
                {

                    bool showState = false;

                    if (_calc.NextStep == StepType.Operation)
                    {
                        Console.WriteLine("Выберете операцию!");
                        string oper = Console.ReadLine();
                        switch (oper)
                        {
                            case "R":
                                StateRound = true;
                                break;
                            case "0":
                                StateRound = false;
                                break;
                            default:
                                showState = _calc.SetOperation(oper);
                                break;  
                        }
                        //showState = _calc.SetOperation(oper);

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

                        if (StateRound)
                        {
                            int znachRound;
                            bool ost;
                            Console.WriteLine("Введите количество знаков после запятой!");
                            ost = int.TryParse(Console.ReadLine(), out znachRound);
                            if (ost)
                            {
                                Console.WriteLine($"Текущее значение = {Math.Round(_calc.State, znachRound)}");
                            }
                            
                        }
                        Console.WriteLine($"Текущее значение = {_calc.State}");

                        //IMemCalc mcalc = _calc as IMemCalc;   //Возвращает null при неудачном преобразовании.
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

        private void EventCalc_StateChanged(double state)
        {
            Console.WriteLine($"Текущее значение = {state}");
        }
    }
}

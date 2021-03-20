using CalcInterface;
using System;

namespace SimpleCalc
{
    public class SimpleCalc : ICalc
    {
        private const string PlusOperation = "+"; //Константы
        private const string MinusOperation = "-";
        private const string MultiOperation = "*";
        private const string DivideOperation = "/";
        private const string ClearOperation = "C";
        private const string EqualOperation = "=";

        private string _operation = null;
        public double State //Автосвойство
        {
            get;
            private set;
        }


        public string[] GetAvailableOperations()
        {
            return new string[] { PlusOperation, MinusOperation, MultiOperation, DivideOperation, EqualOperation, ClearOperation };
        }

        public void SetOperand(double operand)
        {
            switch (_operation)
            {
                case null:
                    State = operand;
                    break;
                case PlusOperation:
                    State += operand;
                    break;
                case MinusOperation:
                    State -= operand;
                    break;
                case MultiOperation:
                    State *= operand;
                    break;
                case DivideOperation:
                    State /= operand;
                    break;
                default:
                    throw new WrongOperationException(); //Break Return Throw завершают case или default
            }
        }

        public void SetOperation(string operation)
        {
            operation = operation.ToUpper();

            switch (operation)
            {
                case ClearOperation:
                    _operation = null;
                    State = 0;
                    return;
                case EqualOperation:
                    _operation = null;
                    return;
                default:
                    _operation = operation;
                    return;
            }
        }
    }
}

//DivideByZeroException для калькулятора.
//Перехват ошибок в CalcService с выводом пользователю.
//Calc передаёт в CalcService смену состояния. Выводить состояние только после = или С или после операции из двух чисел.
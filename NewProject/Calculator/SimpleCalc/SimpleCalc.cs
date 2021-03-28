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
        public StepType NextStep
        {
            get;
            protected set;
        } = StepType.Operand;
          
        public double State //Автосвойство
        {
            get;
            protected set;
        }


        public virtual string[] GetAvailableOperations()
        {
            return new string[] { PlusOperation, MinusOperation, MultiOperation, DivideOperation, EqualOperation, ClearOperation };
        }

        public virtual bool SetOperand(double operand)
        {
            bool result = true;
            switch (_operation)
            {
                case null:
                    State = operand;
                    result = false;
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
                    if (operand == 0)
                    {
                        throw new DivideByZeroException();  
                    }
                    State /= operand;
                    break;
                default:
                    throw new WrongOperationException(); //Break Return Throw завершают case или default
            }
            NextStep = StepType.Operation;
            return result;
        }

        public virtual bool SetOperation(string operation)
        {
            operation = operation.ToUpper();
            bool result = false;

            switch (operation)
            {
                case ClearOperation:
                    _operation = null;
                    State = 0;
                    result = true;
                    break;
                case EqualOperation:
                    _operation = null;
                    return true;
                default:
                    _operation = operation;
                    break;
            }

            NextStep = StepType.Operand;
            return result;

        }
    }
}

//DivideByZeroException для калькулятора.
//Перехват ошибок в CalcService с выводом пользователю.
//Calc передаёт в CalcService смену состояния. Выводить состояние только после = или С или после операции из двух чисел.
//Wrong operation перенести в SetOperation
//CalcWithMemory модифицировать
//Sin Cos Tng
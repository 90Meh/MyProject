using CalcInterface;
using System;
using System.Linq;

namespace SimpleCalc
{
    public class SimpleEventCalc : IEventCalc
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

        public event IEventCalc.StateChangeDelegate StateChanged; //Событие и делегат(тип данных) Тип обработчика событий

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
                    
            }
            NextStep = StepType.Operation;
            return false;
        }

        public virtual bool SetOperation(string operation)
        {
            operation = operation.ToUpper();
            bool result = false;
            if (!GetAvailableOperations().Contains(operation))
            {
                throw new WrongOperationException(); //Break Return Throw завершают case или default
            }

            switch (operation)
            {
                case ClearOperation:
                    _operation = null;
                    State = 0;
                    result = true;
                    break;
                case EqualOperation:
                    _operation = null;
                    if (StateChanged != null)
                    {
                        StateChanged(State);
                    }
                    return false;
                default:
                    _operation = operation;
                    break;
            }

            NextStep = StepType.Operand;
            return false;

        }
    }
}

//DivideByZeroException для калькулятора.
//Перехват ошибок в CalcService с выводом пользователю.
//Calc передаёт в CalcService смену состояния. Выводить состояние только после = или С или после операции из двух чисел.
//Wrong operation перенести в SetOperation
//CalcWithMemory модифицировать
//Sin Cos Tng
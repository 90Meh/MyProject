using CalcInterface;
using System;

namespace DelegateCalculator
{
    public class DelegateCalc : ICalc
    {
        private const string OperationSymbol = "O";
        private readonly CalcOperation _operation;
        private bool flag = false;

        public StepType NextStep
        {
            get;
            private set;
        } = StepType.Operation;

        public double State
        {
            get;
            private set;
        }

        public DelegateCalc(CalcOperation operation)
        {
            _operation = operation;
        }

        public string[] GetAvailableOperations()
        {
            return new string[] { OperationSymbol };
        }

        public bool SetOperand(double operand)
        {
            if (flag)
            {
                State = _operation(State, operand);
                NextStep = StepType.Operation;
                flag = false;
                return true;
            }
            State = operand;
            flag = true;
            return false;
        }

        public bool SetOperation(string operation)
        {
            operation = operation.ToUpper();
            if (operation == OperationSymbol)
            {
                NextStep = StepType.Operand;
                return false;
            }

            throw new WrongOperationException();

        }
    }
}

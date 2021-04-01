using CalcInterface;
using System;
using System.Linq;

namespace CalcAngle
{
    public class CalcSCTG : ICalc
    {
        private const string Sin = "SIN";
        private const string Cos = "COS";
        private const string Tan = "TAN";
        private const string Ctn = "CTN";

        private string _operation = null;

        public StepType NextStep
        {
            get;
            protected set;
        }

        public double State
        {
            get;
            protected set;
        }


        public string[] GetAvailableOperations()
        {
            return new string[] { Sin, Cos, Tan, Ctn };
        }

        public bool SetOperand(double operand)
        {
            bool result = true;
            switch (_operation)
            {
                case null:
                    State = operand;
                    result = false;
                    break;
                case Sin:
                    State = Math.Sin(operand);
                    break;
                case Cos:
                    State = Math.Cos(operand);
                    break;
                case Tan:
                    State = Math.Tan(operand);
                    break;
                case Ctn:
                    State = Math.Cos(operand) / Math.Sin(operand);
                    break;
            }
            NextStep = StepType.Operation;
            return result;
        }

        public bool SetOperation(string operation)
        {
            operation = operation.ToUpper();
            bool result = false;

            if (!GetAvailableOperations().Contains(operation))
            {
                throw new WrongOperationException();
            }

            _operation = operation;
            NextStep = StepType.Operand;
            return result;
        }
    }
}



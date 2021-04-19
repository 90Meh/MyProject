using CalcInterface;
using System;
using System.Linq;

namespace CalcRound
{
    public class Round : SimpleCalc.SimpleCalc, ICalc
    {
        private const string OnRound = "R";

        private bool stateRound = false;
        private int? valueRound = null;



        public override double State
        {
            get => valueRound.HasValue ? Math.Round(base.State, valueRound.Value) : base.State; //Однострочная запись
            protected set => base.State = value;
        }

        public override string[] GetAvailableOperations()
        {
            return base.GetAvailableOperations().Concat(new string[]
            {
               OnRound,
            }).ToArray();
        }

        public override bool SetOperand(double operand)
        {

            if (stateRound)
            {
               valueRound = operand == 0 ? null : Convert.ToInt32(operand);
                //if (operand == 0)
                //{
                //    valueRound = null;
                //}
                //else
                //{
                //    valueRound = Convert.ToInt32(operand);
                //}

                NextStep = StepType.Operation;
                stateRound = false;
                return true;
            }

            return base.SetOperand(operand);

        }


        public override bool SetOperation(string operation)
        {
            operation = operation.ToUpper();
            bool result = false;

            switch (operation)
            {
                case OnRound:
                    stateRound = true;
                    NextStep = StepType.Operand;
                    break;
                default:
                    return base.SetOperation(operation);
            }

            return result;

        }
    }
}

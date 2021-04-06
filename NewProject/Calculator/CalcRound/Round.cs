using CalcInterface;
using System;
using System.Linq;

namespace CalcRound
{
    public class Round : SimpleCalc.SimpleCalc, ICalc
    {
        private const string OnRound = "R";
        private const string OffRound = "0";

        public override string[] GetAvailableOperations()
        {
            return base.GetAvailableOperations().Concat(new string[]
            {
               OnRound,
               OffRound
            }).ToArray();
        }

        public override bool SetOperation(string operation)
        {
            operation = operation.ToUpper();
            bool result = false;

            switch (operation)
            {
                case OnRound:
                    break;
                case OffRound:
                    break;
                default:
                    return base.SetOperation(operation);
            }

            return result;

        }
    }
}

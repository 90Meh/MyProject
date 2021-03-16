using System;

namespace CalcInterface
{
    public interface ICalc
    {
        double State
        {
            get;
        }
        string[] GetAvailableOperations();
        void SetOperation(string operation);
        void SetOperand(double operand);

    }
}

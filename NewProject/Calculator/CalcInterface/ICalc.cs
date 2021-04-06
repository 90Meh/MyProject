using System;

namespace CalcInterface
{
    public interface ICalc
    {
        StepType NextStep
        {
            get;
        }
        double State
        {
            get;
        }

        string[] GetAvailableOperations();
        bool SetOperation(string operation);
        bool SetOperand(double operand);

    }
}

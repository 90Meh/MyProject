using CalcInterface;
using System;

namespace SimpleCalc
{
    public class SimpleCalc : ICalc
    {
        private string _operation = null;
        public double State //Автосвойство
        {
            get;
            private set;
        }


        public string[] GetAvailableOperations()
        {
            return new string[] { "+", "-", "*", "/", "C" };
        }

        public void SetOperand(double operand)
        {
            switch (_operation)
            {
                case null:
                    State = operand;
                    break;
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                case "C":
                    break;
            }
        }

        public void SetOperation(string operation)
        {
            _operation = operation;
        }
    }
}

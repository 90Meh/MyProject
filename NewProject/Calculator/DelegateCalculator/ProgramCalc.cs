using CalcInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    public class ProgramCalc : ICalc
    {
        private readonly Dictionary<string, Func<double, double, double>> _operations;  //Dictionary первым принимает ключ. структура данных ключ и значение. 
                                                                                        //Готовый делегат Func сначала типы принимаемых значени последним возвращаемое.
        private bool flag = false;
        private string tempOperation;

        public ProgramCalc(Dictionary<string, Func<double, double, double>> operations)
        {
            _operations = operations;
        }
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

        public string[] GetAvailableOperations()
        {
            return _operations.Keys.ToArray();
        }

        public bool SetOperand(double operand)
        {
            if (flag)
            {
                State = _operations[tempOperation](State, operand);
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
            if (_operations.ContainsKey(operation))
            {
                NextStep = StepType.Operand;
                tempOperation = operation;
                return false;
            }

            throw new WrongOperationException();

        }
    }
}

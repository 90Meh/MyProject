using CalcInterface;
using System;
using System.Linq;

namespace CalcMem
{
    public class CalcWithMemory : SimpleCalc.SimpleCalc, IMemCalc 
    {
        private const string MemorySaveOperation = "MS";
        private const string MemoryRecordOperation = "MR";
        private const string MemoryClearOperation = "MC";
        private const string MemoryPlusOperation = "M+";
        private const string MemoryMinusOperation = "M-";

        private double? _memory;

        public bool MemState => _memory.HasValue;

        public override string[] GetAvailableOperations()
        {
            return base.GetAvailableOperations().Concat(new string[] //Concat объеденяет два массива и создаёт из них новый не убирая старые
            {
               MemorySaveOperation,
               MemoryRecordOperation,
               MemoryClearOperation,
               MemoryPlusOperation,
               MemoryMinusOperation
            }).ToArray();
        }

        public override bool SetOperation(string operation)
        {
            operation = operation.ToUpper();
            bool result = false;
            //base.SetOperation(operation);
            switch (operation)
            {
                case MemorySaveOperation:
                    _memory = State;
                    break;
                case MemoryRecordOperation:
                    if (_memory.HasValue)
                    {
                        State = _memory.Value;
                        result = true;
                    }
                    break;
                case MemoryClearOperation:
                    _memory = null;
                    break;
                case MemoryPlusOperation:
                    _memory = (_memory ?? 0) + State;
                    break;
                case MemoryMinusOperation:
                    _memory =  (_memory ?? 0) - State;
                    break;
                default:
                    return base.SetOperation(operation);
            }

            return result;

        }
    }
}

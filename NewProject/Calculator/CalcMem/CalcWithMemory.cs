﻿using System;
using System.Linq;

namespace CalcMem
{
    public class CalcWithMemory : SimpleCalc.SimpleCalc
    {
        private const string MemorySaveOperation = "MS";
        private const string MemoryRecordOperation = "MR";
        private const string MemoryClearOperation = "MC";
        private const string MemoryPlusOperation = "M+";
        private const string MemoryMinusOperation = "M-";

        public double? _memory;

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
                    }                    
                    break;
                case MemoryClearOperation:
                    _memory = null;
                    break;
                case MemoryPlusOperation:
                    _memory = (_memory ?? 0) + State;
                    return result = true;
                case MemoryMinusOperation:
                    _memory =  (_memory ?? 0) - State;
                    return result = true;
                default:
                    base.SetOperation(operation);
                    break;
            }

            return result;

        }
    }
}

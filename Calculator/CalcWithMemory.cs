using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class CalcWithMemory : Calc // Наследование
    {
        public static new string[] AvailableOperations()
        {
            return Calc.AvailableOperations().Concat(new string[] { "MS", "MR", "MC", "M+", "M-" }).ToArray(); //concat метод расширения сложили два массива
        }

        private double? _memory; //nullable тип данных

        public CalcWithMemory(double s1) : base(s1) { } //Базовый класс

        public void MemorySave()
        {
            _memory = State;
        }
        public void MemoryRecord()
        {
            if (_memory.HasValue)
            {
                State = _memory.Value; //Значение nullable типа
            }

        }

        public void MemoryClear()
        {
            _memory = null;
        }

        public void MemoryPlus()
        {
            _memory = (_memory ?? 0) + State; //null coalesce если левая часть null он подменяет занчением правой части (0)
        }

        public void MemoryMinus()
        {
            _memory = (_memory ?? 0) - State;
        }
        
    }
}

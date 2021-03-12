using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calc
    {
        public static string[] AvailableOperations()
        {
            return new string[] { "-", "*", "/", "+", "C" };
        }

        private double _state = 0;

        public double State
        {
            get
            {
                return _state;
            }
        }

        public Calc(double s1)
        {
            this._state = s1;
        }

        public double Plus(double p1)
        {
            return _state += p1;
        }

        public double Minus(double m1)
        {
            return _state -= m1;
        }

        public double Multi(double m1)
        {
            return _state *= m1;
        }

        public double Divide(double d1)
        {
            return _state /= d1;
        }

        public void Clear()
        {
            _state = 0;
        }

    }
}

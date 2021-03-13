using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator 
{
    class CalcInteger : ICalc
    {
        private int _state = 0;

        public CalcInteger(double state)
        {
            _state = Convert.ToInt32(state);
        }

        public double State => _state;

        public void Clear()
        {
            _state = 0;
        }

        public double Divide(double d1)
        {
            return _state /= Convert.ToInt32(d1);
        }

        public double Minus(double m1)
        {
            return _state -= Convert.ToInt32(m1);
        }

        public double Multi(double m1)
        {
            return _state *= Convert.ToInt32(m1);
        }

        public double Plus(double p1)
        {
            return _state += Convert.ToInt32(p1); //Класс с методами преобразования
        }
    }
}

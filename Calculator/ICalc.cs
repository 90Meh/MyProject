namespace Calculator
{
    interface ICalc
    {
        double State { get; }

        void Clear();
        double Divide(double d1);
        double Minus(double m1);
        double Multi(double m1);
        double Plus(double p1);
    }
}
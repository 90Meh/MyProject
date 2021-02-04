using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Task4();

        }

        static void Task1()
        {
            //Условия if | else  {}скобки трактуются за одно выражение
            Console.WriteLine("Введите символ!");
            string vvod = Console.ReadLine();

            //сравнение через 2X=
            if (vvod == "5")
            {
                Console.WriteLine("Molodec eto 5!");
                Console.WriteLine("Vozmi s polki pirizok!");
            }
            else if (vvod == "4")
            {
                Console.WriteLine("Horosho no ne molodec!");
            }
            else
            {
                Console.WriteLine("Ya zdu 5, ne molodec!!!");
            }
        }

        static void Task2()
        {
            Console.WriteLine("Введите символ!");
            string vvod = Console.ReadLine();
            bool IsParsed = int.TryParse(vvod, out int Znach);
            if (IsParsed)
            {
                if (Znach >= 5)
                {
                    Console.WriteLine("Ono bolshe!");
                }
                else
                {
                    Console.WriteLine("Ono menshe!");
                }

            }
            else
            {
                Console.WriteLine("Eto ne Chislo!");
            }
        }

        static void Task3()
        {
            Console.WriteLine("Введите символ!");
            string vvod = Console.ReadLine();
            bool IsParsed = int.TryParse(vvod, out int Znach);
            if (!IsParsed)
            {
                Console.WriteLine("Eto ne Chislo!");
            }
            else
            {

                if (Znach >= 5)
                {
                    Console.WriteLine("Ono bolshe!");
                }
                else
                {
                    Console.WriteLine("Ono menshe!");
                }
            }
        }

        static void Task4()
        {
            Console.WriteLine("Введите символ!");
            string vvod = Console.ReadLine();
            bool IsParsed = int.TryParse(vvod, out int Znach);
            //Должно быть не число, строка должна содержать либо точку либо вертикальную черту, но не должна быть равна "|NOT".
            //!vvod.Equals("|NOT", StringComparison.CurrentCultureIgnoreCase))  Позволяет игнорировать регистр. Сравнивает строку с переданной строкой процедурным методом
            if (!IsParsed && (vvod.IndexOf('.') > -1 || vvod.IndexOf('|') > -1) && /*vvod != "|NOT"*/ vvod.ToUpper() != "|NOT")
            {
                Console.WriteLine("Соблюдены");
            }
            else
            {
                Console.WriteLine("Не соблюдены");
            }

        }
    }
}

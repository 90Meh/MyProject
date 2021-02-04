using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Task10();

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

        static void Task5()
        {
            int test = 1;
            Console.WriteLine(test);
            //test++;   // Инкримент прибавляет 1 декримент вычитает 1 "++|--" В зависимости от положения инкримента выполняет до вывода или после.
            Console.WriteLine(test++);
            Console.WriteLine(test);
            Console.WriteLine(++test);

        }

        static void Task6()
        {
            int zero = 0;
            while (zero < 5)   //Объявлениие одного из видов цикла.
            {
                zero++;
                Console.WriteLine($"{zero}, V cikle!");
            }
            Console.WriteLine($"{zero}, Posle cikla!");

        }
        static void Task7()
        {
            int zero = 5;
            do // do один раз заходит в тело цикла и выполняет его
            {
                zero++;
                Console.WriteLine($"{zero}, V cikle!");
            } while (zero < 5);
            Console.WriteLine($"{zero}, Posle cikla!");

        }
        static void Task8()
        {
            int zero = 5;
            switch (zero) //Аналог if else if проверяет значения
            {
                case 0: //Проверка переменной на значение
                    Console.WriteLine("case0!");
                    break;
                case 1:
                    Console.WriteLine("case1!");
                    break;
                case 2:
                    Console.WriteLine("case2!");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("case 3 or 4!");
                    break;
                case 5:
                    Console.WriteLine("case5!");
                    goto case 2;
                default: // Необязателен
                    Console.WriteLine("Default!");
                    break;


            }

        }
        static void Task9()
        {//for задаёт количество повторений цикла условием
            for (int zero = 0; zero < 5; zero++)
            {
                Console.WriteLine("{zero}, V cikle!");
            }
        }
        static void Task10()
        {
            string Hi = "Hello world!";
            for (int zero = 0; zero < Hi.Length; zero++)
            {
                if(Hi [zero] == ' ')
                {
                    break; //Прервает текущий цикл.
                }
                if(Hi  [zero] == 'l')
                {
                    continue; //Заставляет цикл перейти к следующей итерации
                }
                Console.WriteLine(Hi [zero]);
            }
        }


    }
}

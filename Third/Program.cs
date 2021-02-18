using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Task11();

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

        static void Task2() //Bool и TryParse
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

        static void Task3() //Больше/меньше 5 или не число
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

        static void Task4() //if else && || "И" и "Или"
        {
            Console.WriteLine("Введите символ!");
            string vvod = Console.ReadLine();
            bool IsParsed = int.TryParse(vvod, out int Znach);
            
            if (!IsParsed && (vvod.IndexOf('.') > -1 || vvod.IndexOf('|') > -1) && /*vvod != "|NOT"*/ vvod.ToUpper() != "|NOT")
            {
                Console.WriteLine("Соблюдены");
            }
            else
            {
                Console.WriteLine("Не соблюдены");
            }

        }

        static void Task5() //Инкримент Декримент
        {
            int test = 1;
            Console.WriteLine(test);
            //test++;   // Инкримент прибавляет 1 декримент вычитает 1 "++|--" В зависимости от положения инкримента выполняет до вывода или после.
            Console.WriteLine(test++);
            Console.WriteLine(test);
            Console.WriteLine(++test);

        }

        static void Task6() //Цикл While
        {
            int zero = 0;
            while (zero < 5)   //Объявлениие одного из видов цикла.
            {
                zero++;
                Console.WriteLine($"{zero}, V cikle!");
            }
            Console.WriteLine($"{zero}, Posle cikla!");

        }
        static void Task7() //Цикл DO
        {
            int zero = 5;
            do // do один раз заходит в тело цикла и выполняет его
            {
                zero++;
                Console.WriteLine($"{zero}, V cikle!");
            } while (zero < 5);
            Console.WriteLine($"{zero}, Posle cikla!");

        }
        static void Task8() //Цикл Switch
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
        static void Task9() //Цикл FOR
        {//for задаёт количество повторений цикла условием
            for (int zero = 0; zero < 5; zero++)
            {
                Console.WriteLine("{zero}, V cikle!");
            }
        }
        static void Task10() //Операторы Break/continue
        {
            string Hi = "Hello world!";
            for (int zero = 0; zero < Hi.Length; zero++) //Фрагмент кода вызыается "TAB"
            {
                if (Hi[zero] == ' ')
                {
                    break; //Прервает текущий цикл.
                }
                if (Hi[zero] == 'l')
                {
                    continue; //Заставляет цикл перейти к следующей итерации
                }
                Console.WriteLine(Hi[zero]);
            }
        }

        /*
         * 5 значений
         * i    mass[i]
         * 0    2
         * 1    4
         * 2    6
         * 3    8
         * 4    10
         */
        static void Task11() //массивы
        {
            //Массивы хранят последовательность однотипных данных. Могут быть подмассивы. Массив ссылочный тип данных. Когда значения заранее неизвестны. 
            //С массивом можно работать как со строкой
            //int[] Определение типа массива
            int[] mass = new int[5];
            //int znach = 2;

            for (int i = 0; i < mass.Length; i++)
            {
                // mass[i] = znach;
                // znach += 2;
                mass[i] = (i + 1) * 2;
            }

            Console.Write("[");

            /*foreach (int item in mass)
            {
                Console.Write($"{item}, ");
            }*/

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i]);
                //if (mass.Length - 2 >= i)
                if (i < mass.Length - 1)
                {
                    Console.Write(", ");
                }

            }

            Console.WriteLine("]");
            
        }


    }
}

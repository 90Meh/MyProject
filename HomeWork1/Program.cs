﻿using System;
using System.Collections.Generic;

namespace HomeWork1
{
    class Program
    // Type: int, max: 2000, min: -2000 Максимальное и минимальное значение всех переменных

    //Значения ввести самому
    // Считать два числа 1 длина массива 2 стартовое значение 3 шаг изменения.
    // Создать массив и вывести его на экран.
    {
        static void Main(string[] args)
        {
            Task7();
        }
        static void printMass(object[] mass)
        {
            Console.Write("[");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i]);
                if (i < mass.Length - 1)
                {
                    Console.Write(", ");
                }

            }

            Console.WriteLine("]");
        }

        static void Task2()
        {
            Console.Write("Введите символ!\n");
            string vvod = Console.ReadLine();
            bool IsParsed = int.TryParse(vvod, out int Znach);




            if (IsParsed)

            {
                if (Znach < 5)
                {
                    Console.WriteLine("Ono menshe 5!");
                }
                else if (Znach == 5 && Znach < 10)    //////////////////////    "&&" Логическое "И"       Логиские ИЛИ "||"
                {
                    Console.WriteLine("Ono bolshe ili ravno 5 no menishe 10!");
                }
                else
                {
                    Console.WriteLine("Ono bolshe 10!");
                }





                /* if (Znach == 5)
                 {
                     Console.WriteLine("Ono ravno 5!");
                 }
                 else
                 {
                     if (Znach > 5)
                     {
                         Console.WriteLine("Ono bolshe 5!");
                     }
                     else
                     {
                         Console.WriteLine("Ono menshe 5!");
                     }
                 }*/
            }

            else

            {
                int poz = vvod.IndexOf('.');
                Console.WriteLine("Eto ne Chislo!");
                if (poz == -1)

                {
                    Console.WriteLine("V stroke net tochki!");
                }

                else
                {
                    Console.Write("Pozicia tochki v stroke - ");
                    Console.WriteLine(poz);
                }

            }


            /* if (IsParsed)

             {
                 if (Znach <= 10)
                 {
                     Console.WriteLine("Ono menshe ili ravno 10!");
                 }
                 else
                 {
                     Console.WriteLine("Ono bolshe 10!");
                 }


             }*/

            //else
            // {


            //}

        }

        static void Task3() //switch 
        {
            //Должно быть не число, строка должна содержать либо точку либо вертикальную черту, но не должна быть равна "|NOT".
            //!vvod.Equals("|NOT", StringComparison.CurrentCultureIgnoreCase))  Позволяет игнорировать регистр. 
            //Сравнивает строку с переданной строкой процедурным методом
            Console.WriteLine("Vvedite stroku!");
            string vvod = Console.ReadLine();
            for (int NomSim = 0; NomSim < vvod.Length; NomSim++)
            {
                if (vvod[NomSim] == '*')
                {
                    break;
                }
                switch (vvod[NomSim])
                {
                    case '.':
                        Console.WriteLine("DOT");
                        break;
                    case '-':
                        Console.WriteLine("DASH");
                        break;
                    case ' ':
                        Console.WriteLine("SPASE");
                        break;
                    default:
                        Console.WriteLine(vvod[NomSim]);
                        break;
                }

            }





            //Будет вводиться некоторая строка. Выводить каждый символ на новой строке.
            //Условия если это точка вместо сивола вывести строку DOT если тире вывести DASH если пробел то SPACE.
            //Если попадается звёздочка прервать вывод. Swich не If


        }

        static void Task4()
        {

            Console.WriteLine("Введите длину массива!");
            string dlinaMSt = Console.ReadLine();
            int dlinaMint = int.Parse(dlinaMSt);

            Console.WriteLine("Введите стартовое значение!");
            string startSTR = Console.ReadLine();
            int startInt = int.Parse(startSTR);

            Console.WriteLine("Введите шаг изменения!");
            string ShagSTR = Console.ReadLine();
            int ShagInt = int.Parse(ShagSTR);


            int[] mass = new int[dlinaMint];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = startInt;
                startInt += ShagInt;

            }

            Console.Write("[");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i]);
                if (i < mass.Length - 1)
                {
                    Console.Write(", ");
                }

            }

            Console.WriteLine("]");


            int[] mass2 = new int[mass.Length];
            // Array.Copy(mass, mass2, mass.Length);

            for (int i = mass.Length - 1; i >= 0; i--)
            {
                mass2[mass.Length - i - 1] = mass[i];

                /*
                 * mass mass2
                 * 0    4
                 * 1    3
                 * 2    2
                 * 3    1
                 * 4    0
                 */
            }



            /*

            Array.Reverse(mass2);

            Console.Write("[");

            for (int i = 0; i < mass2.Length; i++)
            {
                Console.Write(mass2[i]);
                if (i < mass2.Length - 1)
                {
                    Console.Write(", ");
                }

            }

            Console.WriteLine("]");

            

            int n = mass2.Length; // длина массива
            int k = n / 2;          // середина массива
            int temp;               // вспомогательный элемент для обмена значениями
            for (int i = 0; i < k; i++)
            {
                temp = mass2[i];
                mass2[i] = mass2[n - i - 1];
                mass2[n - i - 1] = temp;
            }
            Console.Write("[");
            /*foreach (int i in mass2)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("]");
            for (int i = 0; i < mass2.Length; i++)
            {
                Console.Write(mass2[i]);
                if (i < mass2.Length - 1)
                {
                    Console.Write(", ");
                }

            }

            Console.WriteLine("]");

            */


            int k1 = mass.Length / 2;
            //Console.WriteLine(mass.Length % 2)

            if (mass.Length % 2 == 0)
            {

                Console.WriteLine($"Массив чётный. Числа в середине масива * 2 - {mass[k1 - 1] * 2}, {mass[k1] * 2}");

                mass[k1 - 1] *= 2;
                mass[k1] *= 2;

            }
            else
            {
                Console.WriteLine($"Массив нечётный. Число в середине массива * 2 - {mass[k1] * 2}");
                mass[k1] *= 2;
            }


            //Значения ввести самому
            // Считать два числа 1 длина массива 2 стартовое значение 3 шаг изменения.
            // Создать массив и вывести его на экран.
            //2-ой: создать ещё один массив. В него скопировать значения из 1-ого в обратном порядке.
            //3 - ий: в 1 - ом массиве центральный элемент(если число элементов чётное, то 2 центральных элемента) умножить на 2.
            //И отдельное задание.
            //Пользователь вводит длину массива.
            //А тебе нужно создать массив указанной длины и заполнить его последовательностью Фибоначи(посмотри на вики) начиная с 0.



        }//Массив наоборот

        static void Task5() //Вывод числовых переменных MAX MIN
        {
            Console.WriteLine("Type     | Min                            | Max                           ");
            Console.WriteLine($"Byte     | {byte.MinValue,-31}| {byte.MaxValue,-32}");
            Console.WriteLine($"Short    | {short.MinValue,-31}| {short.MaxValue}");
            Console.WriteLine($"Int      | {int.MinValue,-31}| {int.MaxValue,-31}");
            Console.WriteLine($"long     | {long.MinValue,-31}| {long.MaxValue,-32}");
            Console.WriteLine($"ushort   | {ushort.MinValue,-31}| {ushort.MaxValue}");
            Console.WriteLine($"uint     | {uint.MinValue,-31}| {uint.MaxValue,-31}");
            Console.WriteLine($"ulong    | {ulong.MinValue,-31}| {ulong.MaxValue}");
            Console.WriteLine($"float    | {float.MinValue,-31}| {float.MaxValue,-31}");
            Console.WriteLine($"decimal  | {decimal.MinValue,-31}| {decimal.MaxValue,-32}");
            Console.WriteLine($"double   | {double.MinValue,-31}| {double.MaxValue}");
            Console.WriteLine();
            String str1 = "";
            Console.WriteLine(str1.PadLeft(100 + str1.Length, '|'));
            Console.WriteLine();



            Console.Write("Type: byte, min: ");
            Console.Write(byte.MinValue);
            Console.Write(", max: ");
            Console.WriteLine(byte.MaxValue);


            Console.Write("Type: short, min: ");
            Console.Write(short.MinValue);
            Console.Write(", max: ");
            Console.WriteLine(short.MaxValue);

            Console.Write("Type: int, min: ");
            Console.Write(int.MinValue);
            Console.Write(", max: ");
            Console.WriteLine(int.MaxValue);

            Console.Write("Type: long, min: ");
            Console.Write(long.MinValue);
            Console.Write(", max: ");
            Console.WriteLine(long.MaxValue);

            Console.Write("Type: ushort, min: ");
            Console.Write(ushort.MinValue);
            Console.Write(", max: ");
            Console.WriteLine(ushort.MaxValue);

            Console.Write("Type: uint, min: ");
            Console.Write(uint.MinValue);
            Console.Write(", max: ");
            Console.WriteLine(uint.MaxValue);

            Console.Write("Type: ulong, min: ");
            Console.Write(ulong.MinValue);
            Console.Write(", max: ");
            Console.WriteLine(ulong.MaxValue);

            Console.Write("Type: float, min: ");
            Console.Write(float.MinValue);
            Console.Write(", max: ");
            Console.WriteLine(float.MaxValue);

            Console.Write("Type: decimal, min: ");
            Console.Write(decimal.MinValue);
            Console.Write(", max: ");
            Console.WriteLine(decimal.MaxValue);

            Console.Write("Type: double, min: ");
            Console.Write(double.MinValue);
            Console.Write(", max: ");
            Console.WriteLine(double.MaxValue);

            // Все строки в режиме интерполяции и с выравниванием

            //Послле ввода | не число | меньше пяти | больше= пяти | но меньше либо равно 10 | больше десяти
            // Если это строка выведет позицию первой возможной точки символ. Если точки нет написать здесь нет точек.

        }

        static void Task6()//Фибоначи
        {
            //Пользователь вводит длину массива.
            //А тебе нужно создать массив указанной длины и заполнить его последовательностью Фибоначи(посмотри на вики) начиная с 0.


            Console.WriteLine("Введите длину массива!");
            string dlinaMSt = Console.ReadLine();
            int dlinaMint = int.Parse(dlinaMSt);

            int[] mass = new int[dlinaMint];

            Console.WriteLine("Введите первое число!");
            string xSt = Console.ReadLine();
            int x = int.Parse(xSt);
            mass[0] = x;

            if (mass.Length > 1)
            {
                Console.WriteLine("Введите второе число!");
                string ySt = Console.ReadLine();
                int y = int.Parse(ySt);
                mass[1] = y;
            }



            for (int i = 2; i < mass.Length; i++)
            {
                mass[i] = mass[i - 1] + mass[i - 2];
            }

            /*
            
            int c;

            for (int j = 0, i = 1, k = 2; (j < dlinaMint) ^ (i < dlinaMint) ^ (k < dlinaMint); j += 3, i += 3, k += 3)
            {
                mass[j] = x;
                mass[i] = y;
                c = x + y;
                mass[k] = c;
                x = c + y;
                y = c + x;

            }

            */

            Console.Write("[");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i]);
                if (i < mass.Length - 1)
                {
                    Console.Write(", ");
                }

            }

            Console.WriteLine("]");


        }

        static void Task7() //числа в массив  <БЭКСПЭЙС маст хэв
        {
            Console.WriteLine("Введите пять чисел разделяя их пробелами!");
            string[] MassSTR = new string[5];
            Stack<string> MassTemp = new Stack<string>(); //Массив который увеличивается по мере заполнения LIST      Очередь Queue
            string znach = "";
            int PozM = 0;

            while (PozM < 5)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Backspace)
                {
                    //Диапазон значение enum
                    if (znach == "")
                    {
                        if (MassTemp.Count == 0)
                        {
                            continue;
                        }
                        znach = MassTemp.Pop();
                        if (PozM > 0 && znach == MassSTR[PozM - 1])
                        {
                            PozM--;
                        }
                    }
                    else
                    {
                        znach = znach.Substring(0, znach.Length - 1);
                    }
                    Console.CursorLeft--;
                    Console.Write(' ');
                    Console.CursorLeft--;
                    continue;
                }

                Console.Write(key.KeyChar);

                if (key.KeyChar == ' ')
                {
                    bool parsZ = double.TryParse(znach, out double znach1);
                    if (!parsZ)
                    {
                        MassTemp.Push(znach);
                        znach = "";
                        continue;
                    }

                    MassSTR[PozM] = znach;
                    PozM++;
                    MassTemp.Push(znach);
                    znach = "";


                }
                else
                {
                    znach += key.KeyChar;
                }

            }

            Console.WriteLine();
            Console.Write("[");

            for (int i = 0; i < MassSTR.Length; i++)
            {
                Console.Write(MassSTR[i]);
                //if (mass.Length - 2 >= i)
                if (i < MassSTR.Length - 1)
                {
                    Console.Write(", ");
                }

            }

            Console.WriteLine("]");




            //Пять чисел в массив разделённых пробелами, фильтр символов. Считывание только целых чисел.
            //Фибоначи
        }

        // Массив double replace
        //Class1 дописать метод вернуть строку имя поля и значение поля. перечисляющюу значения всех филдов подписанных.
        //Перед этим поговорить с пользователем.
        //Class1 новый метод выдать строку не выводя в консоль. Привет * вот мои поля.
    }

}
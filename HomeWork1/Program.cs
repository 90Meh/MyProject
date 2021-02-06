using System;

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
            /*Console.WriteLine("Type     | Min                            | Max                           ");
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
            Console.WriteLine();*/

            Task3();


            /*Console.Write("Type: byte, min: ");
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
            Console.WriteLine(double.MaxValue);*/

            // Все строки в режиме интерполяции и с выравниванием

            //Послле ввода | не число | меньше пяти | больше= пяти | но меньше либо равно 10 | больше десяти
            // Если это строка выведет позицию первой возможной точки символ. Если точки нет написать здесь нет точек.


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

        static void Task3()
        {
            Console.WriteLine("Vvedite stroku!");
            string vvod = Console.ReadLine();
            for (int NomSim = 0; NomSim < vvod.Length; NomSim++)
            {
                if(vvod [NomSim] == '*')
                {
                    break;
                }
                switch (vvod [NomSim])
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
    }
}
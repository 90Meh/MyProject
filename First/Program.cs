using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            /*    int perem = 8;
                Console.WriteLine("Hello World!");
                Console.Write("This Is My perem ");
                Console.Write(perem);
                Console.WriteLine();
                perem = 10;
                Console.Write("This Is My perem ");
                Console.Write(perem);
                Console.WriteLine();
                int perem2 = 4;
                int perem3 = perem * perem2;
                Console.WriteLine(perem3);
                perem3 = perem + perem2;
                Console.WriteLine(perem3);
                perem3 = perem2 % perem;
                Console.WriteLine(perem3);
                perem+= perem2;
                Console.WriteLine(perem);
                perem = 300;
                byte b1 = 250;
                Console.WriteLine(b1);
                b1 = (byte)perem;
                Console.Write(b1);
                Console.WriteLine();
                ushort q;
                //uint r = ();
                //ulong w = ();
                Console.Write(int.MaxValue);
                // Type: int, max: 2000, min: -2000 Максимальное и минимальное значение всех переменных

                perem = (10 + 5 )* 2;
                //Плавающие точки
                //
                //float
                //decimal
                //double
                //1е34 Экспоненциальная запись
                float perem4 = 1.4f;

                perem = 1_000_000;
                int i1 = 10;
                int i2 = 3;
                //Приведение типов
                double doubl1 = (double)i1 / i2;//Операция деления с остатком
                Console.WriteLine(doubl1);
                double sinA=
                //Math математические операции
                Math.Sin(doubl1);
                Console.Write("sinA = ");
                Console.WriteLine(Math.Sin(doubl1));
                Console.Write("logA = ");
                Console.WriteLine(Math.Log(doubl1));
                //byte b1 = 10;
                //int i3 = b1;
                int i4 = 300;
                byte b2 = (byte)i4;
                Console.WriteLine(b2);
                bool boolT = true;
                bool boolF = false;
                //условные операторы

                char char1 = 'Ȓ';
                //Один символ из кодовых таблиц (utf8)

                //Контрольные символы записываются через обратный "\"

                char newLine = '\n'; //Символ переноса строки
                Console.Write("Chto nibud'");
                Console.Write(newLine);
                Console.Write("Esho cto nibud'");
                Console.WriteLine();

                char CarR = '\r'; //Возвращает каретку в начало
                Console.Write("123456789");
                Console.Write(CarR);
                Console.Write("98765");

                char Tab = '\t'; //Символ табуляции

                char UniC = '\u0245';
                Console.WriteLine(UniC);

                char Zero = '0';
                int Izero = Zero;
                Console.WriteLine(Izero);
                char Zero2 = (char)Izero;
                Console.WriteLine(Zero2);

                //Примитивные и ссылочные типы данных всё что выше примитивные типы.

                string str1 = "Hello World!";
                Console.WriteLine(str1);
                Console.WriteLine(str1.Length); //Длина строки
                //int perem = 0;
                char CH1 = str1[perem]; //Квадратные скобки позиция символа
                string str2 = str1.Substring(0, 5);
                string str3 = str1.Substring(6,5);
                Console.WriteLine(str3);
                char CH2 = str1[11];
                Console.WriteLine(CH2);
                //str1.Trim() Убирает пробелы в начале и конце
                string str4 = "   С пробелами в конце и начале    ";
                string str5 = str4.Trim();
                Console.WriteLine(str4);
                Console.WriteLine(str5);

                Console.WriteLine (str1.Remove(6, 5));
                Console.WriteLine(str2);
                int poz = str1.IndexOf('o'); //Ищет позицию символа по строке, если его нет возвр. -1 str1.LastIndexOf ищет с конца
                Console.WriteLine(poz);
                int poz2 = str1.IndexOf('o',poz+1);
                Console.WriteLine(poz2);
                Console.WriteLine(str1.ToLower()); //Переводит в нижний регистр
                Console.WriteLine(str1.ToUpper()); // Переводит в верхний регистр
                Console.WriteLine(str1.PadLeft(4+str1.Length,'-')); // Дозаполняет строку символами либо пробелами если не указано
                // Null Значение ничто только для ссылочных типов
                string name = "Ivan";
                string name2= "Misha";
               // string.Format("Hello world {0} !",name);   Фигурные скобки указывают место подстановки Старый формат
                Console.WriteLine(string.Format("Hello world {0} !", name));
                Console.WriteLine(string.Format("Hello {0},{1} !", name,"Misha"));
                Console.WriteLine("Hello {0},{1} !", name, "Misha"); //Уже используют метод string.format
                Console.WriteLine($"Hello {name}, {name2} !"); //Интерполяция строк ноовый формат
                Console.WriteLine();
                Console.WriteLine($"{"Ivan",-15}: {45, 5}|{178, 6:f2}"); //Форматирование строки выравнивание /f признак числа после запятой $включает режим интерполяции
                Console.WriteLine($"{"Kain", -15}: {400, 5}|{34, 6:f2}");
                Console.WriteLine($"{"Kemberbetch", -15}: {2588, 5}|{18427, 6:f2},{{\"\\5\\\"}}"); //Экранирование (5)
                int chislo = 23;
                Console.WriteLine(chislo.ToString("d4"));
                string longStr = @"onsole.WriteLine (str1.Remove(6, 5));
                int poz = str1.IndexOf('o'); //Ищет позицию символа по строке, если его нет возвр. -1 str1.LastIndexOf ищет с конца 
                Console.WriteLine(poz);
                int poz2 = str1.IndexOf('o',poz+1);
                Console.Write \n Line(poz2);
                Console.WriteLine \t (str1.ToLower()); //Переводит в нижний регистр
                Console.WriteLine(str1.ToUpper()); // Переводит в верхний регистр
                ""Console.WriteLine(str1.PadLeft(4+str1.Length,'-')); // Дозаполняет строку символами либо пробелами если не указано""
                // Null Значение ничто только для ссылочных типов";
                Console.WriteLine(longStr);  //@ Записывает текс с переносами, без экранирования, без него читает только до конца строки @ и $ Могут использоваться вместе
                int Perevod = int.Parse("5754"); // Парсит строку, переводит из строки в число ""=int
                Console.WriteLine(Perevod + 1);
                Console.WriteLine(decimal.Parse("531,7"));

                */
        }
    }
}
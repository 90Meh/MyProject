using System;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string vvod = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string vvod2 = Console.ReadLine();
            int vvodCH = int.Parse(vvod);
            int vvodCH2 = int.Parse(vvod2);
            // Console.WriteLine(vvodCH + 5);
            int Sum1 = vvodCH + 5;
            int Sum2 = vvodCH + vvodCH2;
            Console.WriteLine($"{vvod} + 5 = {Sum1}");  //Интерполировали строку складывали значение введённое пользователем
            Console.WriteLine($"{vvod} + {vvod2} = {Sum2}");
            Console.WriteLine($"{Sum1} * {Sum2} = {Sum1 * Sum2}");

        }
    }
}

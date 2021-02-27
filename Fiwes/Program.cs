using Fiwes.sub;
using System;

namespace Fiwes
{
    namespace test
    {
        //Пространство имён внутри
    }
    class Program
    {
        static void Main(string[] args)
        {
            task3();
        }

        static void task1 ()
        {
            Class1 c1 = new Class1(); //ссылочный тип данных
            //c1 = null; //значение по умолчанию
            c1.Field = 5;
            c1.Prop1 = 6;
            Console.WriteLine(c1.Field);
            Console.WriteLine(c1.Prop1);
            Console.WriteLine(c1.Prop2);
            c1.Field = 10;
            Console.WriteLine(c1.Prop2);
            c1.Prop2 = 2;
            Console.WriteLine(c1.Field);
            //c1.Field2 = 3;
            //c1.Prop3 = 3; 
            c1.SetField2(50);
            Console.WriteLine(c1.Prop3);
            Console.WriteLine(c1.GetFieldSumm());

            State state = State.NotStarted;
            //string t = State.InProgress.ToString();
        }

        static void task2()
        {
            Class1 c1 = new Class1();
            Console.WriteLine(c1.PropS);
            c1.Field = 5;
            c1.SetField2(4);
            Console.WriteLine(c1.PropS);
            Console.WriteLine(c1.GetFieldSumm());
            Console.WriteLine(c1.PropS);
            Console.WriteLine($"Первый филд! = {c1.Field}");
            c1.SetField2(6);
            Console.WriteLine(c1.GetFieldSumm());
            
        }

        static void task3()
        {
            Class1 c1 = new Class1();
            Console.WriteLine("Введите первое значение!");
            String a1 = Console.ReadLine();
            bool a1Pars = (int.TryParse(a1, out int a2));
            if(a1Pars == true)
            {
                c1.Field = a2;
            }
            else
            {
                Console.WriteLine("Значение должно быть числом!");
                return;
            }

            Console.WriteLine("Введите второе значение!");
            string b1 = Console.ReadLine();
            bool b1Pars = (int.TryParse(b1, out int b2));
            if (b1Pars == true)
            {
                c1.SetField2(b2);
            }
            else
            {
                Console.WriteLine("Значение должно быть числом!");
                return;
            }
            
            c1.ZnachF();
        }

    }
}

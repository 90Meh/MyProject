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
        }

    }
}

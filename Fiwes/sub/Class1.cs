using System;
using System.Collections.Generic;
using System.Text;

namespace Fiwes.sub
{
    class Class1 // public и internal Модификатор доступа

    //Поле конкретная переменная которую можно разное.
    //Свойство с чем то взаимодействует но не имеет конкреного значения.
    {
        public int Field;
        private int Field2;
        public string Name1;

        public int Prop1
        {
            get; //Обращение извне
            set; // Запись извне
            //Автосвойства
        }

        public int Prop2
        {
            get
            {
                Console.WriteLine("Вызван Prop2 get");
                return Field;
            }
            set
            {
                Console.WriteLine("Вызван Prop2 set");
                Field = value;
            }
        }

        public int Prop3
        {
            get
            {
                return Field2;
            }
        }

        public string Hi
        {

             get
            {
                string p2 = $"Привет {Name1} мои поля равны {Field} и {Field2}!";
                return p2;
            }
        }

        public State PropS  //enum
        {
            get;
            private set;
        }

        public Class1() //Конструктор начальное состояние объекта. Перегрузка. Одно имя с разными параметрами.
        {
            PropS = State.NotStarted;
        }

        public Class1(int field, int field2)
        {
            this.Field = field;
            this.Field2 = field2;
            PropS = State.InProgress;
        }

        public void SetField2(int Param1)
        {
            if (PropS == State.Finished)
            {
                return;
            }
            this.Field2 = Param1; //this обращение самому к себе
            //Field2 = Param1;
            PropS = State.InProgress;
        }

        public void Name()
        {
            this.Name1 = Console.ReadLine();
        }

        public int GetFieldSumm()
        {
            PropS = State.Finished;
            return Field + Field2;
        }


        public void ZnachF()
        {
            Console.WriteLine("Нажмите пробел чтобы получить значение полей");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == ' ')
            {
                Console.WriteLine();
                Console.WriteLine($"Наименование поля 1 Field значение  = {Field}");
                Console.WriteLine($"Наименование поля 2 Field1 значение = {Field2}");
                Console.WriteLine($"Сумма значений полей                = {GetFieldSumm()}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Вы ввели {key.KeyChar}");
            }
        }

        public int Overloaded(int s1)//перегруженный метод   подпись метода
        {
            return Field + s1;

        }

        public int Overloaded(int s1, int s2)
        {
            return Overloaded(s1) + s2;
        }

        public int Recurce(int r1) //Рекурсия
        {
            /*  if (r1 ==1)
              {
                  return 1;
              }

              return r1 + Recurce(r1 - 1);*/
            return r1 == 1 ? 1 : r1 + Recurce(r1 - 1);  //Тернарные операторы """"?"""". IF записанный строкой
        }

        public int Sum(params int[] slag) //params неограниченное число параметров последний параметр в массиве
        {
            int sum = 0;
            foreach (int item in slag)
            {
                sum += item;
            }
            return sum;
        }

        public double Calc(Operation operation, params double[] slag)
        {
            var result = slag[0];
            /*{
                Operation.Minus => slag[0];
                o
            }*/
            var isFirst = true;
            foreach (var item in slag)
            {
                if (item == 4)
                {
                    throw new Exception("Я не люблю четвёрки!"); //Всегда прерывает выполнение
                }
                if (isFirst)
                {
                    isFirst = false;
                    continue;
                }
                switch (operation)
                {
                    case Operation.Plus:
                        result += item;
                        break;
                    case Operation.Minus:
                        result -= item;
                        break;
                    case Operation.Multiple:
                        result *= item;
                        break;
                    case Operation.Division:
                        result /= item;
                        break;
                }

            }
            return result;
        }

        public string Hellow(string nameParam)
        {
            return $"Привет {nameParam} мои поля равны {Field} и {Field2}!";
        }

    }
}

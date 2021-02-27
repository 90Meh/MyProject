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

        public State PropS  //enum
        {
            get;
            private set;
        }

        public Class1() //Конструктор начальное состояние объекта
        {
            PropS = State.NotStarted;
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
    }
}

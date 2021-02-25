using System;
using System.Collections.Generic;
using System.Text;

namespace Fiwes.sub
{
    class Class1 // public и internal Модификатор доступа
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

        public void SetField2(int Param1)
        {
            this.Field2 = Param1; //this обращение самому к себе
            //Field2 = Param1;

        }

        public int GetFieldSumm()
        {
            return Field + Field2;
        }
    }
}

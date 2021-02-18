﻿using System;

namespace Forth
{
    class Program
    {
       
        static void Main(string[] args)
        {
            task1();
        }

        static void task1() //ReadKey
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true); //Возвращает нажатие клавиши с модификаторами
                // Console.ReadKey   ConsoleKeyInfo возвращает сложный объект
                Console.WriteLine($"{nameof(key.KeyChar)}: {key.KeyChar}, {nameof(key.Key)}: {key.Key}, {nameof(key.Modifiers)}: {key.Modifiers}!");
                
                    
            }
        }

        static void printMass(object[] mass) //Вывод массива 
        {
            Console.Write("[");

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

        static void task2()
        {
                       
            Console.WriteLine("Введите длину массива!");
            string DLMassStr = Console.ReadLine();
            int DLMassInt = int.Parse(DLMassStr);

            string[] MassStr = new string[DLMassInt];
            string slovo = "";
            int PozM = 0;
            while (PozM < MassStr.Length)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                
                if (key.KeyChar == ' ')
                {
                    MassStr[PozM]= slovo;
                    PozM++;
                    slovo = "";
                }
                else
                {
                    slovo += key.KeyChar;
                }
             
            }

            printMass(MassStr);

        }


    }
}

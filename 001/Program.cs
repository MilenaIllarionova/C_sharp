//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
using System;

namespace SecondDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int secondDigit = (number / 10) % 10;

            Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
        }
    }
}
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
using System;

namespace ThirdNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int num = int.Parse(Console.ReadLine());

            int thirdNum = (num / 100) % 10;

            if (thirdNum == 0)
            {
                Console.WriteLine("В числе нет третьей цифры");
            }
            else
            {
                Console.WriteLine($"Третья цифра числа {num} равна {thirdNum}");
            }
        }
    }
}
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
using System;

namespace Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день недели: ");
            int day = int.Parse(Console.ReadLine());

           if (day ==6 || day == 7)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}


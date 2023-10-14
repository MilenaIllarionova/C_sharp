Задача 25
Console.Write("Введите числа a и b через запятую: ");
string input = Console.ReadLine();
string[] numbers = input.Split(',');
int a = int.Parse(numbers[0]);
int b = int.Parse(numbers[1]);

int result = 1;

for (int i = 0; i < b; i++)
{
    result *= a;
}

Console.WriteLine("Число {0} в степени {1} равно {2}", a, b, result);

//Задача 26
using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        int sum = 0;
        foreach (char c in input) {
            sum += int.Parse(c.ToString());
        }
        Console.WriteLine($"Сумма цифр в числе: {sum} ");
    }
}

//Задача 27
using System;

class Program {
    static void Main(string[] args) {
        int[] arr = new int[8];
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rnd.Next(1, 101);
        }

        Console.WriteLine("Массив: [" + string.Join(", ", arr) + "]");
    }
}
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int number = Mess("Введите число: ");

PrintDigit(number);

int Mess(string msg)
{
    Console.Write(msg);
    string dig = Console.ReadLine()!;
    if ((int.TryParse(dig, out int dig2)) == false)
    {
        Console.Write($"Вы ввели не число: {dig}");
    }
    return dig2;
}

void PrintDigit(int number)
{
    while (100 < number)
    {
        number = number / 10;
    }

    Console.Write($"{number % 10} ");
}

// Метод 2

// Console.WriteLine("Введите трёхзначное число: ");
// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Вы ввели число: {number}");
// int num_res = number / 10;
// int result = num_res % 10;
// Console.WriteLine($"Вторая цифра вашего числа это {result}!");

// 1 добавим первый коммит 

// 2 Добавим второй коммит

// 3 Добавим третий коммит

// тестируем git 
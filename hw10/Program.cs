// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число N: ");
        int num = Convert.ToInt32(Console.ReadLine());
if (num.ToString().Length != 3)
{
    Console.Write("Введено некорректное число N: ");
    return;
}

char secondDigit = num.ToString()[1];
Console.WriteLine($"Вторая цифра числа {num} равна {secondDigit}");
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// хз как бесконечность писать
if (number >= 100 && number <= 1000000)
    {
    int thirdDigit = (number / 10) % 10;
    Console.WriteLine($"Третья цифра числа: {thirdDigit}");
    }
        else
    {
        Console.WriteLine("Третьей цифры нет");
    }
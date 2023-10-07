// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;

class Program
{
    static void Main()
    {
        int[] array = GenerateRandomArray(8); // Вызываем метод для создания массива из 8 случайных чисел

        Console.Write("Массив: [");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    static int[] GenerateRandomArray(int length)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(1, 100); // Генерируем случайное число от 1 до 100
        }

        return array;
    }
}

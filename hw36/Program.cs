// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// создаем массив и заполняем случайными числами
        int[] array = new int[4];

        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 100);
        }

        // выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        // находим сумму элементов на нечетных позициях
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        // выводим сумму на экран
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);

        Console.ReadLine();

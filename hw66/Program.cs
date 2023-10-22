// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



    static int SumNaturalNumbers(int m, int n)
    {
        if (m > n)
        {
            return 0;
        }
        else
        {
            return m + SumNaturalNumbers(m+1, n);
        }
    }
 
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int sum = SumNaturalNumbers(m, n);
        
        Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sum}.");
   


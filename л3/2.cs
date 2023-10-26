using System;

// Из N введённых целых чисел найти количество элементов,
// у которых есть хотя бы одна "3" в записи,
// при этом нельзя использовать строковые методы

class NumbersNote
{
    public static void Main()
    {
        int count = 0;
        Console.WriteLine("Введите N");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите N целых чисел");
        for (int i = 0; i < N; i++)
        {
            int n=Math.Abs(Convert.ToInt32(Console.ReadLine()));
            while (n > 0)
            {
                if (n % 10 == 3)
                {
                    count++;
                    break;
                }
                else n = n / 10;
            }
        }
        Console.WriteLine("Количество чисел, содержащих '3': {0}", count);

    }
}
using System;

// Из N введённых целых чисел найти наименьшее нечётное

class Min
{
    public static void Main()
    {
        int a = int.MaxValue;
        Console.WriteLine("Введите N");
        int N=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите N целых чисел");
        for (int i = 0; i < N; i++)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(n) % 2 == 1) a = Math.Min(a, n);
        }
        Console.WriteLine("Наименьшее нечётное: {0}", a);
    }
}
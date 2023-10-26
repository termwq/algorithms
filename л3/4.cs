using System;

// Из N введённых чисел вывести количество элементов
// с одинаковыми окончаниями с троичной, пятеричной и семеричной системах счисления

class Systems
{
    public static void Main()
    {
        int count = 0;
        Console.WriteLine("Введите N");
        int N=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите N чисел");
        for (int i = 0; i < N; i++)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            if (n % 3 == n % 5 && n % 3 == n % 7) count++;
        }
        Console.WriteLine("Количество: {0}", count);
    }
}
using System;

// Для 10-ти чисел найти сумму элементов 
// с одинаковым окончанием в троичной и пятеричной система счисления

class Same_end
{
    public static void Main()
    {
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 3 == n % 5)
            {
                sum += n;
            }
        }
        Console.WriteLine("Сумма: {0}", sum);
    }
}

using System;

// Максимальная сумма элементов из N пар кратная трем
// или сообщение о том, что такая сумма невозможна
class Pairs
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int[] mins1 = { Int32.MaxValue, Int32.MaxValue };
        int[] mins2 = { Int32.MaxValue, Int32.MaxValue };
        int sum = 0;

        for (int i = 0; i < N; i++)
        {
            string[] pair = Console.ReadLine().Split(' ');

            int n1 = Convert.ToInt32(pair[0]);
            int n2 = Convert.ToInt32(pair[1]);
            int dif = Math.Abs(n1 - n2);

            if (dif % 3 == 1)
            {
                if (dif < mins1[0])
                {
                    mins1[0] = dif;
                }
                else if (dif < mins1[1])
                {
                    mins1[1] = dif;
                }
            }
            else if (dif % 3 == 2)
            {
                if (dif < mins2[0])
                {
                    mins2[0] = dif;
                }
                else if (dif < mins2[1])
                {
                    mins2[1] = dif;
                }
            }

            sum += Math.Max(n1, n2);
        }

        bool A = (mins1[0] < Int32.MaxValue || mins1[1] < Int32.MaxValue)
            || (mins2[0] < Int32.MaxValue && mins2[1] < Int32.MaxValue);
        bool B = (mins2[0] < Int32.MaxValue || mins2[1] < Int32.MaxValue)
            || (mins1[0] < Int32.MaxValue && mins1[1] < Int32.MaxValue);

        if (sum % 3 == 0)
        {
            Console.WriteLine("Максимальная сумма кратная трем: {0}", sum);
        }
        else if (sum % 3 == 1 && A)
        {
            int s1 = ((mins1[0] < mins1[1]) ? mins1[0] : mins1[1]);
            int min = s1;

            if (mins2[0] < Int32.MaxValue && mins2[1] < Int32.MaxValue)
            {
                int s2 = mins2[0] + mins2[0];
                min = (min < s2 ? min : s2);
            }

            if (min < Int32.MaxValue)
            {
                sum = sum - min;
            }

            Console.WriteLine("Максимальная сумма кратная трем: {0}", sum);
        }
        else if (sum % 3 == 2 && B)
        {
            int r2 = ((mins2[0] < mins2[1]) ? mins2[0] : mins2[1]);
            int min = r2;

            if (mins1[0] < Int32.MaxValue && mins1[1] < Int32.MaxValue)
            {
                int r1 = mins1[0] + mins1[0];
                min = (min < r1 ? min : r1);
            }

            if (min < Int32.MaxValue)
            {
                sum = sum - min;
            }

            Console.WriteLine("Максимальная сумма кратная трем: {0}", sum);
        }

        else
        {
            Console.WriteLine("Такой суммы нет :(");
        }

    }
}
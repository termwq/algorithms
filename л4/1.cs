using System;
using System.Linq;

// Дано K мышек. Из них одна белая, остальные серые. Мышки сидят по кругу.
// Кот начинает съедать каждую M мышку.
// Определить, с какой мышки кот должен съедать каждую M, чтобы
// в конце осталась одна белая мышка.
// При этом нельзя использовать полный перебор, 
// а позиция белой мышки задаётся в начале программы.

class Mice
{
    public static void Main()
    {
        Console.WriteLine("Введите количество мышей (K)");
        int K=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите M");
        int M=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите позицию белой мышки");
        int w=Convert.ToInt32(Console.ReadLine());

        int[] m = new int[K];
        for (int i = 0; i < K; i++) m[i] = 0;

        int p = 0;
        m[p] = 1;
        while (m.Count(c=>c==0) > 0)
        {
            int move = 0;
            while(move !=M)
            {
                ++p;
                if (p > K - 1) p = 0;
                if (m[p] == 0) ++move;
            }
            m[p] = 1;
        }
        int dif = p - w;
        int x = (K - dif) % K;
        Console.WriteLine("Ответ: {0}", x);
    }
}
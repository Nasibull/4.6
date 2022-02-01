using System;

namespace Макс_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите чило K: ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[N];
            int[] mas2 = new int[M + K];
            Random rnd = new Random();

            if (1 < K & K < N)
            {
                if (1 < M & M < 10)
                {
                    for (int i = 0; i < N; i++)
                    {
                        mas[i] = rnd.Next(0, 21);
                        Console.Write(mas[i] + " ");
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < N; i++)
                    {
                        if (i == K)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(mas[i] + " ");
                        }
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < M + K; i++)
                    {
                        mas2[i] = 0;
                    }
                    for (int i = 0; i < K + M; i++)
                    {
                        if (i < K)
                        {
                            Console.Write(mas[i] + " ");
                        }
                        else
                        {
                            Console.Write(mas2[i] + " ");
                        }
                    }
                }
            }
        }
    }
}
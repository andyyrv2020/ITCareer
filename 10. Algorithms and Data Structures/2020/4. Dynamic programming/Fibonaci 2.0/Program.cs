﻿using System;

namespace Fibonaci_2._0
{
    class Program
    {
        // Памет
        static long[] memo;

        // Рекурсивен метод за пресмятане на редицата на Фибоначи
        static long Fibonacci(int n)
        {
            // Използване на предишно получена стойност
            if (memo[n] != 0) return memo[n];

            // Получаване на нова стойност и запазване в паметта
            if (n <= 2) memo[n] = 1;
            else memo[n] = Fibonacci(n - 2) + Fibonacci(n - 1);
            return memo[n];
        }

        static void Main(string[] args)
        {
            // Вход
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            // Създавне на паметта
            memo = new long[n + 1];

            // Използване на рекурсивната функция с памет
            Console.WriteLine(Fibonacci(n));

            // По-желание можем да отпечатаме цялата редица
            Console.WriteLine(string.Join(", ", memo));
        }
    }
}

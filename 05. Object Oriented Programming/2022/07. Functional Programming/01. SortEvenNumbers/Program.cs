﻿using System;
using System.Linq;

namespace _01._SortEvenNumbers
{
    internal class Program
    {
        // https://judge.softuni.bg/Contests/Practice/Index/597#0
        static void Main(string[] args)
        {
            // input
            int[] numbers = Console.ReadLine()
                  .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(n => int.Parse(n))
                  .Where(n => n % 2 == 0)
                  .OrderBy(n => n)
                  .ToArray();

            // output
            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
﻿using System;

namespace Game
{
    public static class Console
    {
        /// <summary>
        /// Отпечатване на текст на конзолата в зeлен цвят
        /// </summary>
        /// <param name="text">Текст за отпечатване</param>
        public static void WriteLine(string text)
        {
            var color = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(text);
            System.Console.ForegroundColor = color;
        }

        public static void Write(string text)
        {
            var color = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(text);
            System.Console.ForegroundColor = color;
        }
    }
}
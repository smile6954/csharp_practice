﻿using System;
using static System.Console;
int max;
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

if (a > b)
    {
    max = a;
    }
else
    max = b;

WriteLine($"Максимальное число = {max}");
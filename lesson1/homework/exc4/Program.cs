using System;
using static System.Console;
int max;
WriteLine("Task2");
WriteLine("введите число a");
int a = int.Parse(ReadLine());
WriteLine("введите число b");
int b = int.Parse(ReadLine());
WriteLine("введите число c");
int c = int.Parse(ReadLine());

if (a > b)
{
    max = a;
}
else 
    max = b;

if (max > c)
{
    WriteLine($"Максимальное число = {max}");
}
else
    WriteLine($"Максимальное число = {c}");

using System;
using static System.Console;

WriteLine("Введите число N");
int N = int.Parse(ReadLine());
WriteLine($"В диапазоне от 1 до {N} есть честные числа:");
int i = 1;

while (i <= N)
{
    if (i%2 == 0)
    {
        WriteLine(i);
    }
    i++;
}

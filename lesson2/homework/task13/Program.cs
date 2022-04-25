using System;
using static System.Console;

Clear();
WriteLine("Введите число");
String a1 = ReadLine();
if (a1.Length < 3)
{
WriteLine("Третьего числа нет");
}
else 

WriteLine($"Третье число - {a1[2]}");

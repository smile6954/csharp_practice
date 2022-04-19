using System;

int num = int.Parse(Console.ReadLine());
int y = num%10;
int x = num/1000;
Console.WriteLine($"Вы ввели число {num}");
Console.WriteLine($"остаток от деления = {y} \nпервая цифра = {x}");


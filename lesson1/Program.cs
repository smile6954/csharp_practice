using System;
using static System.Console;

WriteLine("Vvedite int");
int number = int.Parse(ReadLine());
int sqr = number*number;
WriteLine($"number={number} Result = {sqr}"); // знак $ позволяет в текстовую строку внедрять числа в {}



using System;
using static System.Console;

WriteLine("Введите день недели");
int dayNumber = int.Parse(ReadLine());
if(dayNumber > 0 && dayNumber < 8)
{
    if(dayNumber > 0 && dayNumber < 6)
    WriteLine("Не выходной день");
    else
    WriteLine("Выходной день");
}
else
WriteLine("Такого дня недели не существует");

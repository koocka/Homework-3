﻿//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int X = 0;
while (num > 0)
{
    int Y = num % 10;
    num = num / 10;
    X = X + Y;
}
Console.WriteLine($"Сумма всех цифр числа равняет {X}");

﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
int Digree(int num1, int num2)
{
    int result = 1;
    int i = 1;
    while (i <= num2)
    {
        result = result * num1;
        i++;
    }
    return result;
}
Console.WriteLine("Введите число А : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B : ");
int b = Convert.ToInt32(Console.ReadLine());
int digree = Digree(a,b);
Console.WriteLine($"Число {a} в степени {b} = {digree}");


﻿// Задача 67
// Принимает на вход число и возвращает сумму его цифр

using System.Text.RegularExpressions;
using System;
using static System.Console;
using System.Data;

Clear();
try
{
    Write("Введите число N: ");
    int N = int.Parse(ReadLine());
    WriteLine(SumNumber(N, 0));
    WriteLine(Sum(N)); //От преподавателя

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}
catch
{
    Write("Ошибка выполнения!");
}

int SumNumber(int N, int sum)
{
    if (N == 0) return sum;
    return SumNumber(N / 10, sum + N % 10);
}

int Sum(int number)
{
    if (number == 0) return 0;
    return (number % 10 + Sum(number / 10));
}
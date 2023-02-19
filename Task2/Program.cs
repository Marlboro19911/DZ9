﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.WriteLine(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumWithRecursion(int start, int finish)
{
    if (start > finish)
    {
        return 0;
    }
    return start + SumWithRecursion(start + 1, finish);
}

int firstNum = Prompt("Введите первое число");
int secondNum = Prompt("Введите второе число");
int result = SumWithRecursion(firstNum, secondNum);
Console.WriteLine($"Сумма чисел от {firstNum} до {secondNum} = {result}");
﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

Console.WriteLine("Ведите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 99)
{
    for (int i = N; i >= 1000; i = i / 10)
    {
        N /= 10;
    }
    if (N >= 100 && N <= 999)
    {
        N = N % 10;
    }
    Console.WriteLine($"Третья цифра {N}");
}
  else
{
    Console.Write($"Третьей цифры нет");
}
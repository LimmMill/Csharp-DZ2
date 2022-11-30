// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

 Console.Write("Введдите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count;
    count = num % 100 / 10;

 Console.WriteLine($"Вторая цифра из {num}, будет {count}");
// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
DayOffCheck(dayNumber);


void DayOffCheck(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Да, выходной день");
    }
    else if (dayNumber > 0 && dayNumber < 6)
    {
        Console.WriteLine("это будний день");
    }
    else
    {
        Console.WriteLine("Ошибка, введите число от 1 до 7");
    }
}
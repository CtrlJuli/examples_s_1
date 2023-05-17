// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

int dayOff = number;

bool IsDayOff(int dayOff)
{
    if (dayOff > 5)
    {
        return true;
    }
    return false;
}

bool CheckDayOff(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}

if (CheckDayOff(dayOff))
{
    if (IsDayOff(dayOff))
    {
        Console.WriteLine("Да, выходной!");
    }
    else
    {
        Console.WriteLine("Нет, не выходной!");
    }
}
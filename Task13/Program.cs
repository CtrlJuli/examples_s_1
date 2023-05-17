// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Prompt = number;

int ThirdNumber(int number)
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}

bool CheckNumber(int number)
{
if (number < 100)
return false;
else return true;
}

if (CheckNumber(number) != true)
System.Console.WriteLine("Третьей цифры нет");
else
System.Console.WriteLine($"Третья цифра числа -> {ThirdNumber(number)}");
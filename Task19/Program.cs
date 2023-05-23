// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");

int num = int.Parse(Console.ReadLine());

if (num >=0)
{
    num = IntervCheck(num);
    bool palindr = PalindrFunc(num);
    string result = palindr == true ? $"Да, число является палиндромом!" 
    : $"Нет, число не является палиндромом!";
    Console.WriteLine(result);
}
else
{
    Console.WriteLine($"Число является отрицательным");
    Console.WriteLine("Отрицательные числа не могут быть палиндромами!");
}


bool PalindrFunc(int n)
{
    int firstN = n / 10000;
    int fifthN = n % 10;
    int secN = (n / 1000) % 10;
    int fourthN = (n % 100) / 10;
    return (firstN == fifthN && secN == fourthN) ? true : false;
}

int IntervCheck (int number)
{
    while ((number < 10000) || (number > 99999))
    {
        Console.WriteLine("Число не является пятизначным!");
        Console.WriteLine("Введите новое число");
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

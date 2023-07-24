// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPalindrome(int number)
{
    if (number / 10000 == number % 10 & number / 1000 % 10 == number % 100 / 10)
        Console.WriteLine($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите пятизначное число: ");
CheckPalindrome(number);
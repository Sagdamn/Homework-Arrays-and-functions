/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length == 5)
{
    PalindromeSearch(number);
}
else Console.WriteLine($"Данное число не соответствует условию задачи. Введите пятизначное число: ");

void PalindromeSearch(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
        Console.WriteLine($"Ваше число {number} является палиндромом.");
    else
        Console.WriteLine($"Ваше число {number} НЕ является палиндромом.");
}
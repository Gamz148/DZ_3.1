// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());

//int number = 12321; // замените это число на нужное вам
string numberString = number.ToString();
bool isPalindrome = true;

for (int i = 0; i < numberString.Length / 2; i++)
{
    if (numberString[i] != numberString[numberString.Length - 1 - i])
    {
        isPalindrome = false;
        break;
    }g
}

if (isPalindrome)
{
    Console.WriteLine("Число " + number + " Да");
}
else
{
    Console.WriteLine("Число " + number + " Нет");
}
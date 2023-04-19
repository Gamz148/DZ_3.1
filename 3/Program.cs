// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("введите число N: ");
int N = int.Parse(Console.ReadLine());
System.Console.WriteLine($"выводим результат куба числа от 1 до {N}");
for (int i = 1; i<=N; i++)
    System.Console.WriteLine(Math.Pow(i,3)+ " ");



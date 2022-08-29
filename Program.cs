// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
if (day<6) Console.WriteLine("No");
if (day>7) Console.WriteLine("Такого дня недели нет");
else Console.WriteLine("Yes");
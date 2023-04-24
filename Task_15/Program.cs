// Задача 15: 

// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter a DAY number, PLEASE!");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Is that day a WEEKEND?");

if (num >= 1 && num <= 5) Console.WriteLine("NO, looks like is a WORKING DAY!");
if (num >= 6 && num <= 7) Console.WriteLine("YES, it is!");
if (num <= 0) Console.WriteLine("ERROR, enter a number from 1 to 7!");
if (num > 7) Console.WriteLine("ERROR, enter a number from 1 to 7!");
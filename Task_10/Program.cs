// Задача 10:

// Напишите программу, которая принимает на вход 
// трехзначное число и на выходе показывает ВТОРУЮ цифру
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter ANY three-digit number");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num % 100;
int las = num % 10;
int mid = (num2 - las) / 10;

Console.WriteLine("The second number of your three-digit number is: " + (mid));
// Задача 13: 

// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter ANY number, PLEASE!");
int num = Convert.ToInt32(Console.ReadLine());
int k = 1;
int find = 1;

if (num < 100) Console.WriteLine("There is NO third number");

else
    while (num >= 100 * k)
    {
        find = (num % (10 * k)) / k;
        k = k * 10;
    }

if (num >= 100)	System.Console.WriteLine("The third number is: " + (find));

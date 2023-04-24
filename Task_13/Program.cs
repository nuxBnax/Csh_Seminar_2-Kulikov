// Задача 13: 

// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter ANY number, PLEASE!");
int num = Convert.ToInt32(Console.ReadLine());
// int count = 100;
int k = 1;
int find = 1;

if (num < 100) Console.WriteLine("There is NO third number");
// if (num >= count && num <= (count * 10) - 1) Console.WriteLine("The third number is: " + ((num % (10 * k)) / k));
// if (num >= 1000 && num <= 9999) Console.WriteLine("The third number is: " + ((num % (10 * k)) / (10 * k)));
// if (num >= 10000 && num <= 99999) Console.WriteLine("The third number is: " + ((num % (10 * k)) / k));
if (num >= 100)
{
	while (num >= 100 * k && num <= ((1000 * k) - 1)) 
	{
		find = (num % (10 * k)) / k;
        k = k * 10;
    }
    
Console.WriteLine("The third number is: " + (find));
}


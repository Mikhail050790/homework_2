// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int num = new Random().Next(10, 1000);

Console.WriteLine("Число");

int num1 = (num % 100)/10;

Console.WriteLine(num);

Console.WriteLine(num1);

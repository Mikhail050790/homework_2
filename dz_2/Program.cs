﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



int num= new Random(). Next(1, 1000);

Console.WriteLine(num);

if(num > 99)
{
    Console.WriteLine("Третья цифра" +num.ToString()+" = "+num.ToString()[2]);
}

else
    {
        Console.WriteLine("Третьей цифры нет");
    }
       
    
﻿/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/ 
int sumOfDigits(int Number)
{
                int sum = 0;
                for (int i = Number; i > 0;)
                {
                    sum = sum + i % 10; 
                    i = i / 10;            
                } 
                return sum;
            } 
int getNumberFromUser(string message)
{
    int result = 0;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(message);
    Console.ResetColor();
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}            
int Number = getNumberFromUser("Введите число:   ");
int sum = sumOfDigits(Number);
Console.WriteLine("Сумма цифр в числе: " + sum);

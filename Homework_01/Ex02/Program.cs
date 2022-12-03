// Задача 2: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введённое число является чётным?");

int number = 8;

if (number % 2 == 0)
{
Console.Write (number);
Console.Write (" - да, это чётное число!");
}
else
{
Console.Write (number); 
Console.Write (" - нет, это нечётное число!");
}
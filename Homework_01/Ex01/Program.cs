// Задача 1: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("start");

int a = 44, b = 5, c = 78;
int max;

if (a > b)
{
  max = a;
}
else
{
  max = b;   
} 
if (a > c)
{
  max = a;
}
else
{
  max = c;   
} 
if (b > c)
{
  max = b;
}
else
{
  max = c;   
} 

Console.WriteLine (max);
Console.WriteLine ("end");
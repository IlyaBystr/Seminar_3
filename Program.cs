﻿/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)
*/

/*Console.WriteLine("Введите число");
string a = Console.ReadLine()!;
if (a.Length == 5)
{
    if (a[0] == a[4] && a[1] == a[3])
    {
        Console.WriteLine("Число является полиндромом");
    }
    else{
        Console.WriteLine("Число не являеться полиндромом");
    }
}
else
{
    Console.WriteLine("Введено неверное число");
}
*/


/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

/*
Console.Write("Введите координаты x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
*/

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

/*
Console.WriteLine("Введите число от 1");
int a = int.Parse(Console.ReadLine()!);
int i =1;
while(i<=a)
{
    if (a>=1)
    {
    Console.WriteLine($"{Math.Pow(i, 3)}");
    i++;
    }
    else
    {
        Console.WriteLine("Вы ввели не верное число");
    }
}
*/
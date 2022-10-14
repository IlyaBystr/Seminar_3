Console.WriteLine("Введите число");
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


int num = new Random().Next(10,1000);
System.Console.WriteLine($"Твое число {num}");
int a = num % 10;

if (num > 100)
{
    Console.WriteLine($"Результат {a}");
}
else{
    Console.WriteLine($"третьей цифры нет");
}
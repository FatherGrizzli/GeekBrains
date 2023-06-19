int num = new Random().Next(100,1000);
System.Console.WriteLine($"Твое число {num}");
int a = num / 10 % 10;
System.Console.WriteLine($"Результат {a}");
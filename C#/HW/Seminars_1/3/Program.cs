Console.WriteLine("Введите число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());;

if (NumberA % 2 == 0) 
{
     Console.WriteLine( NumberA  + " делимое число");
}

else
{
    Console.WriteLine("Неделимое число");
}
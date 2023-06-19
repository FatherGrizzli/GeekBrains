Console.WriteLine("Введите день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 6)
{
    Console.WriteLine($" {number} нет это будний");
}
else
{
    Console.WriteLine($" {number} да это выходной");
}
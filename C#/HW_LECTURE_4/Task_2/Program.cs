//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число");
int num_1 = Convert.ToInt32(Console.ReadLine());
int sum = SummaNum(num_1);
Console.WriteLine($"Сумма цифр {num_1} равно: {SummaCount(num_1,sum)} ");

int SummaNum(int num_1)
{
    int index = 0;
    while (num_1 > 0)
    {
        num_1 /= 10;
        index++;
    }
    return index;
}
int SummaCount(int num_1, int sum)
{
    int SummaCount = 0;
    for (int i = 0; i <= sum; i++)
    {
        SummaCount += num_1 % 10;
        num_1 /= 10;
    }
    return SummaCount;
}


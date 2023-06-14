//Console.WriteLine("Today is Friday");
//Console.Write("Today is Friday");

//Console.ReadLine();
//Задача1
//Напишите прогрмму, которая вход принимает число и выдает его квадарат 
//1. Запрос число 
//2 возводим квадрат 
//3  вывести квадрат 

/*Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine(result);
Console.WriteLine($"Entered number is {number}. Square is {result}");
*/

//int, double (float), bool

//Задача 3.
// Напишите программу которая на вход принимает два числа и проверяет,
// является ли первое число квадаратом второго 
//1. запросить и записать 2 числа 
//2. срравнить первое == квадрат второго 
//3. вывести резуль

/* Console.WriteLine("Enter first number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

if (numb1 == numb2 * numb2)
{
    Console.WriteLine("firs number is a square of the second one");
}
else
{
   Console.WriteLine("firs number is NOT a square of the second one"); 
}
*/

/*
Задача 5 
Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
1. Запрос и запись часла
2. Новая перменная  = число из п.1 (-1)
3. count = число п.2
4. пока наш count меньше либо равен числа из п.1 -> вывод count -> count++

*/
/*
Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = number * (-1);

while (count <= number)
{
    Console.Write(count + ", ");
    count = count +1;
}
*/

/* Задача 7.
Напиши прогрмму, которая принимает на вход трехзначное число
на выходе показывает последнию цифру этого числа.
 8 / 3 = 2 Деление нацело
 11 % 3 = 2 остаток от деления 11 на 3 

456 % 10 = 6
456 / 10 = 45
456 % 100 = 56 
456 / 100 = 4
456 % 1000 = 456
456 / 1000 = 0

*/

/*
*/

Console.WriteLine("Enter your number: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());
// && - логическое и
// || - логическая или 
if(lastNumber > 99 && lastNumber < 1000)
{
    //int digit_3 = lastNumber % 10;
    //Console.WriteLine("the third digit is " + digit_3);
    Console.WriteLine("the third digit is " + lastNumber % 10);
}
else
{
    Console.Write("ERROR");
}

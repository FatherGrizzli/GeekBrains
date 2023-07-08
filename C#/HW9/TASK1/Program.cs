/*void PrintNumbers(int n)
    {
        if (n < 0) PrintNumbers((n)-1);
        Console.Write(n + " ");
        
    }
PrintNumbers(10);
Альтернативное решение но не смог развернуть массив так таковой 
*/
using System;

class Program
{
    static void PrintNumbers(int n)
    {
        if (n == 1)
        {
            Console.Write(n);
            return;
        }
        Console.Write(n + ", ");
        PrintNumbers(n - 1);
    }

    static void Main()
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        PrintNumbers(N);
    }
}

//Альтернатива 
/*
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}

int n = Prompt("Input N: ");
if (n < 1)
{
  Console.WriteLine("Ввдите положительное число!");
  return;
}
Console.WriteLine(NaturalNumber(n, 1));
*/
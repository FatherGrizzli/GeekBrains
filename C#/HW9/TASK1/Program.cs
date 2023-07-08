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
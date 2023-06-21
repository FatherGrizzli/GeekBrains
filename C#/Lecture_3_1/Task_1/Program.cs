 /*
            | Y
            |
            |
   II       |       I
            |
 _______________________X
            |
   III      |       IV
            |

x > 0, y > 0 I quater
x > 0, y < 0 IV quater
x < 0, y < 0 III quater
x < 0, y > 0 II quater
*/

// Напиши программу, которая принимает на вход координаты точки (X и Y)
// причем X не равен 0 и Y не равен 0 и выдает номер четверти плоскасти, в которой находится эта точка 

/*
void NameFunk () // невозратный метод, NameFunk - название метода, в скобках аргумент
{
<body>
}

NameFunk(); // вызов метода, имя метода + аргументы 
*/

/*
Int, bool, double, string FunktName ( int arg1, int arg2.....)
*/

// Напиши прогрмму, которая получает на вход 2х значное число и показывает наиболие большое

// Найти остатот от деление введеного числа на 9

int FunktName (int arg1, int arg2)
{      // arg1 = number;
       // arg2 - 9;
        int del = arg1 % arg2;

 return del;
}

Console.WriteLine("Input ");
int number = convert.ToInt32(Console.ReadLine());
int resul = FunktName(number, 9);
Console.WriteLine("1" + FunktName(number, 9));
int resul1 = FunktName(1000, 78);
Console.WriteLine("2" + resul1);

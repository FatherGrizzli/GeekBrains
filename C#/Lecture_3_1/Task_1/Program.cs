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

/*int FunktName (int arg1, int arg2)
{      // arg1 = number;
       // arg2 - 9;
        int del = arg1 % arg2;

 return del;
}

Console.WriteLine("Input ");
int number = Convert.ToInt32(Console.ReadLine());
int resul = FunktName(number, 9);
Console.WriteLine("1 " + FunktName(number, 9));
int resul1 = FunktName(1000, 78);
Console.WriteLine("2 " + resul1);
*/

/*
void FunktName1()
{
       Console.WriteLine("Input ");
       int number = Convert.ToInt32(Console.ReadLine());

       int del = number % 9;
       Console.WriteLine("1 " + del);
       }

FunktName1();
*/
//Напишите программу которая принимает кординату X и Y

/*
int Koord (int x, int y)
{
       int numberQuater;
       if (x > 0 && y > 0)
              numberQuater = 1;
       else if (x > 0 && y < 0)
              numberQuater = 4;
       else if (x < 0 && y > 0)
              numberQuater = 2;
       else 
              numberQuater = 3;
       return numberQuater;
       }

       Console.WriteLine("Enwter X coord ");
       int xCoord = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enwter Y coord ");
       int yCoord = Convert.ToInt32(Console.ReadLine());
       int numbQuat;
       if (xCoord == 0 || yCoord == 0)
       {
              Console.WriteLine("Error!");
              while (xCoord == 0)
              {
                     Console.WriteLine("TRY AGAIN");
                     xCoord = Convert.ToInt32(Console.ReadLine());
              }
       }
       else
       {
       numbQuat = Koord (xCoord, yCoord);
       Console.WriteLine($"Number of quater is {numbQuat}");
       }
       */

//Напишите программу которая по номеру четверти 
// показывает диапозон возможных координат точек в этой четверти (x и y)

/*
int Diapason (int quadro)
{
       //int quadro1;
       //int quadro2;
       ///int quadro3;
       //int quadro4;
       if (quadro == 1)
       {
              return quadro1 = 1;
       }
       else if (quadro == 2)
              return 2;
       else if (quadro == 3)
              return 3;
       else if (quadro == 4)
              return 4;
       

}
int result = Diapason()
if (result -- 1)
{
       Console.WriteLine("Ваш диапозон x > 0 и y > 0");
       

}
*/
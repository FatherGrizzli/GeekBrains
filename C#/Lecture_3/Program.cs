//Задайте массив из 12 элементов, заполненных случайными числами из промежкутка [-9, 9]
//Найдите сумму отрицательных и положительных элементов массива.
/*int [] CreateArray (int size, int MinVal, int maxVal)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(MinVal, maxVal + 1);
    }
    return newArray;
}

void ShowArray (int [] arrayToShow)
{
    for(int i = 0; i < arrayToShow.Length; i++)
        Console.Write (arrayToShow[i] + " ");
    Console.WriteLine();
}


void FindSumNegElem (int array)
{
    int sumNegElem = 0;
    for (int i = 0; i < array.length; i++)
        if (array[i] < 0)
            sumNegElem += array[i];
    Sonsole.WriteLine($"Summ of negative elements of array is {sumNegElem}");

}

int FindSumPosElem (int [] arrayToAnalyse)
{
    int sumPosElem = 0;
    for (int i = 0; i < arrayToAnalyse.GetHashCode.Length; i++)
        if (arrayToAnalyse[i] > 0)
            sumPosElem += arrayToAnalyse[i];
    return sumPosElem;
}
*/
/*
void FindSumNegElem (int [] array)
{
    int sumNegElem = 0;
    int sumPosElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < 0)
            sumNegElem += array[i];
        if (array[i] > 0)
            sumPosElem += arrat[i];
    }
    Console.WriteLine($"Summ of negatibe elements of array is {sumNegElem}");
    Console.WriteLine($"Summ of negatibe elements of array is {sumPosElem}");
}
*//*
int sizeArray = 12;
int minArrayVal = -9;
int maxArrayVal = 9;

int [] createdArray = CreateArray(sizeArray, minArrayVal, maxArrayVal);
ShowArray(createdArray);
FindSumNegElem (createArray);
int positiveSum = FindSumPosElem(createdArray);
Console.WriteLine($"Sum of positive elements of array is {ositiveSumm}");
*/
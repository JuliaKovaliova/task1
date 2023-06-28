// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int [] CreateArray (int size)
{
    int [] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(100,1000);
    }
    return randomArray;
}

void PrintArray (int [] arrayToPrint)
{
    Console.WriteLine("Array is: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write (arrayToPrint[i] + " ");
}

void FindEvenNumber (int [] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            amount = amount + 1;
        }
    }
    Console.Write ("Amount even number: " + amount);
}


int size = 10;
int [] firstArray = CreateArray(size);
PrintArray(firstArray);
Console.WriteLine();
FindEvenNumber(firstArray);
*/

/*

// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateArray (int size)
{
    int [] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(100,1000);
    }
    return randomArray;
}

void PrintArray (int [] arrayToPrint)
{
    Console.WriteLine("Array is: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write (arrayToPrint[i] + " ");
}

void FindSumOddNumber (int [] currentArray)
{
    int sum = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + currentArray[i];
        }
    }
    Console.WriteLine("Sum of odd positions: " + sum);
}

int size = 10;
int [] firstArray = CreateArray(size);
PrintArray(firstArray);
Console.WriteLine();
FindSumOddNumber(firstArray);
*/

// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] CreateArray (int size)
{
    double [] randomArray = new double [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = (new Random().NextDouble()) * 100;
    }
    return randomArray;
}

void PrintArray (double [] arrayToPrint)
{
    Console.WriteLine("Array is: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write (arrayToPrint[i] + " ");
}


void FindMaxMinArray (double[]array)
{
    double diff = 0;
    double min = array[0]; 
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>max)
            {
                max=array[i];
            }
            if (array[i]<min)
            {
                min=array[i];
            }
        }
    diff = max-min;
    Console.WriteLine("-> " + diff);
}


int size = 10;
double [] firstArray = CreateArray(size);
PrintArray(firstArray);
FindMaxMinArray(firstArray);



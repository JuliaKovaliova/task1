// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

string[] GetArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите значение ячейки: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[" + "\t");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "," + "\t");
    }
    Console.Write("]");
}

int CountElements(string[] arr)
{
    int newArrayLength = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int wordLength = arr[i].Length;
        if (wordLength <= 3)
        {
            newArrayLength++;
        }
    }
    return newArrayLength;
}

string[] NewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int wordLength = array[i].Length;
        if (wordLength <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] result = GetArray(arraySize);
PrintArray(result);
Console.WriteLine();
Console.WriteLine("Преобразованная матрица: ");
PrintArray(NewArray(result, CountElements(result)));

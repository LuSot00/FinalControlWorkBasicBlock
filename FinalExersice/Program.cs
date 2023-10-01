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

string[] Selection(string[] arr)
{
    string[] newArray = new string[0];
    int newArrayLength = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int length = arr[i].Length;
        if (length <= 3)
        {
            if (i == arr.Length)
            {
                newArray = new string[newArrayLength];
                for (int j = 0; j < arr.Length; j++)
                {
                    length = arr[i].Length;
                    if (length <= 3)
                    {
                        newArray[j] = arr[j];
                    }
                }
            }
            else
            {
                newArrayLength++;
            }
        }
    }
    return newArray;
}


string[] result = GetArray(arraySize);
PrintArray(result);
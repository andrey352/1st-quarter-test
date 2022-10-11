// Задача: Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше
// либо равна 3 символам. Первоначальный массив можно ввести с клав-ы, либо задать на старте выполнения алгоритма
// Пример: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

string[] array1 = {"hello", "2", "world", ":-)"};
string[] newArray = new string[array1.Length];

void GetResultArray (string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

GetResultArray(array1);
PrintArray(newArray);
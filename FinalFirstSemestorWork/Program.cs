/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Примеры:
["hallo", "2", "world", ":-)"] -> ["2", ":-)"]
["Russia", "Denmark", "Kazan"] -> []
*/

// Получить размерность массива с консоли
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}

// Получить массив строк с консоли
string[] GetBaseArray(int lengthArray)
{
    string[] baseArray = new string[lengthArray];
    string newString = String.Empty;

    Console.WriteLine("Введите строки массива, после каждой <Enter>");

    for (int count = 0; count < lengthArray; count++)
    {
        newString = Console.ReadLine();
        if(newString != null)
        baseArray[count] = newString;
    }

    return baseArray;
}

// печать массива в консоль
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// создать новый массив
string[] GetNewArray(string[] array)
{
    int dimension = 0;
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            dimension++;
        }
    }

    string[] newArray = new string[dimension];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }

    return newArray;
}

int dimension = GetNumber("Введите количество строк, которое хотите ввести");
Console.WriteLine();
string[] baseArray = GetBaseArray(dimension);
PrintArray(baseArray);
Console.WriteLine();
string[] newArray = GetNewArray(baseArray);
PrintArray(newArray);
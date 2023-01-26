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
    //объявление переменных
    string[] baseArray = new string[lengthArray];
    string result = String.Empty;

    // ввод строк с клавиатуры
    Console.WriteLine("Введите строки массива, после каждой <Enter>");

    for (int count = 0; count < lengthArray; count++)
    {
        result = Console.ReadLine();
        baseArray[count] = result;
        if (result == null)
        {
            break;
        }
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

int dimension = GetNumber("Введите количество строк, которое хотите ввести");
string[] baseArray = GetBaseArray(dimension);
PrintArray(baseArray);
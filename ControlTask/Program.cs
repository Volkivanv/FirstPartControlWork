
// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
// алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


class Program
{
    static string[] InputStringArray(string message, char splitter)
    {
        Console.WriteLine(message);
        string? inputString = Console.ReadLine();
        return inputString.Split(splitter);

    }
    static string[] SelectLenghtLessN(string[] stringArr, int N)
    {
        string[] outStringArr = Array.Empty<string>();
        for (int i = 0; i < stringArr.Length; i++)
        {
            if (stringArr[i].Length <= N)
                outStringArr = outStringArr.Append(stringArr[i]).ToArray();
        }
        return outStringArr;
    }

    static void PrintStringArray(string[] stringArr)
    {
        Console.WriteLine(string.Join(", ", stringArr));
    }
    static void Main(string[] args)
    {
        string[] inStrings = InputStringArray("Введите строки через запятую", ',');
        string[] outStrings = SelectLenghtLessN(inStrings, 3);
        PrintStringArray(outStrings);

    }
}

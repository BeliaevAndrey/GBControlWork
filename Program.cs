using System;

class Program
{
    public static string[] Chooser(string[] array, int maxLenth=3)  // Метод для обработки массива.
    {
        int count = 0;
        string[] result = new string[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxLenth)
            {
                Array.Resize(ref result, result.Length + 1);
                result[count] = array[i];
                count++;
            }
        }
        return result;
    }

    public static string ArrayToString(string[] array)  // Метод для формирования выходной строки.
    {
        if(array.Length == 0)
            return "[]";
        return $"[ \"{string.Join("\", \"", array)}\" ]";
    }

    static void Main()
    {
    string[] inArray1 = { "hello", "2", "world", ":-)" };
    string[] inArray2 = { "1234", "1567", "-2", "computer science" };
    string[] inArray3 = { "Russia", "Denmark", "Kazan" };
    string[] inArray4 = { "Russia", "Denmark", "Kazan", 
                        "1234", "1567", "-2", "computer science", 
                        "hello", "2", "world", ":-)", 
                        "Bye", "hI", "Io", "Phobos", "Deimos"
                        };

    Console.WriteLine($"{ArrayToString(inArray1)} -> {ArrayToString(Chooser(inArray1))}");
    Console.WriteLine($"{ArrayToString(inArray2)} -> {ArrayToString(Chooser(inArray2))}");
    Console.WriteLine($"{ArrayToString(inArray3)} -> {ArrayToString(Chooser(inArray3))}");
    Console.WriteLine($"{ArrayToString(inArray4)} -> {ArrayToString(Chooser(inArray4))}");

    }

}
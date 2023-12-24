// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число M:");
        int startNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число N:");
        int endNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Натуральные числа в промежутке:", startNum, endNum);
        PrintNaturalNumbers(startNum, endNum);

        Console.ReadLine();
    }

    static void PrintNaturalNumbers(int currentNum, int endNum)
    {
        Console.WriteLine(currentNum);

        if (currentNum < endNum)
        {
            PrintNaturalNumbers(currentNum + 1, endNum);
        }
    }
}

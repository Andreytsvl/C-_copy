// Задайте произвольный массив. Выведете его элементы, начиная с конца

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 6, 4, 0, 15, 1 }; // Произвольный массив

        PrintArrayReversed(array, array.Length - 1); // Вызов рекурсивной функции для печати элементов массива

        Console.ReadLine();
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]); // Вывод текущего элемента

            PrintArrayReversed(array, index - 1); // Рекурсивный вызов для следующего элемента
        }
    }
}
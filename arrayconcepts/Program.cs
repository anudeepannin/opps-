using System;
public class Program
{
    public static void Main()
    {
        int[,] arri = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine("Original Array");
        DisplayArray(arri);
        for (int i = 0; i < arri.GetLength(0); i++)
        {
            for (int j = 0; j < arri.GetLength(1); j++)
            {
                arri[i, j] *= 2;
            }
        }
        Console.WriteLine("Updated Array ");
        DisplayArray(arri);
    }
    static void DisplayArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine("\n");
        }
    }
}
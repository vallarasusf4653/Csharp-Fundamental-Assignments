using System;
namespace ArrayAssignment;
public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[5];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                }
            }

        }
        Console.WriteLine("After Sorting :");
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
    }
}
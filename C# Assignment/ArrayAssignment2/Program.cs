using System;
namespace ArrayAssignment2;
public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[10];
        int even = 0;
        int odd = 0;
        for (int start = 0; start < array.Length; start++)
        {
            array[start] = int.Parse(Console.ReadLine());
            if (array[start] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }

        }
        int[] arr1 = new int[even];
        int[] arr2 = new int[odd];
        

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                even--;
                arr1[even] = array[i];
            }
            else
            {
                odd--;
                arr2[odd] = array[i];
            }
        }






        for (int k = 0; k < arr1.Length; k++)
        {
            for (int l = k + 1; l < arr1.Length; l++)
            {
                if (arr1[k] > arr1[l])
                {
                    int temp = arr1[k];
                    arr1[k] = arr1[l];
                    arr1[l] = temp;

                }
            }

        }
        Console.WriteLine("After ascending order Sorting :");
        foreach (int value in arr1)
        {
            Console.WriteLine(value);
        }

        for (int m = 0; m < arr2.Length; m++)
        {
            for (int n = m + 1; n < arr2.Length; n++)
            {
                if (arr2[m] < arr2[n])
                {
                    int temp = arr2[m];
                    arr2[m] = arr2[n];
                    arr2[n] = temp;

                }
            }

        }
        Console.WriteLine("After decending  Sorting :");
        foreach (int value in arr2)
        {

            Console.WriteLine(value);
        }
    }
}
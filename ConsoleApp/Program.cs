using System;

namespace BubbleSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 72, 3, 14, 7, 1 };

            

            Bubble_Sort(numbers);

            Console.WriteLine("Sorted array:");
            PrintArray(numbers);
        }

        
        static void Bubble_Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int x = 0; x < arr.Length - i - 1; x++)
                {
                    if (arr[x] > arr[x + 1])
                    {
                        int temp = arr[x];
                        arr[x] = arr[x + 1];
                        arr[x + 1] = temp;
                    }
                }
            }
        }

        
        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}

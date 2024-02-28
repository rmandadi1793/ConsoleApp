using System;

namespace classdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 72, 3, 14, 7, 1 };
            BubbleSort(numbers);

            Console.WriteLine("Sorted array:");
            PrintArray(numbers);
        }

        static void BubbleSort(int[] arr)
        {
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}


using System;

class Program
{
    public static void Main()
    {
        static int Partition(int[] arr,int low,int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for(int j = low; j <= high-1; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        static void Swap(int[] arr,int a,int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        static void QuickSort(int[] arr,int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        static void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }

        int[] array = { 6, 2, 9, 4, 7, 3, 6 };
        QuickSort(array, 0, array.Length-1);
        PrintArray(array);
    }
}
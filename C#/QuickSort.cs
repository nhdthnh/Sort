using System;

class QuickSort {
    int Partition(int[] arr, int low, int high) {
        int pivot = arr[high];
        int i = (low - 1);

        for (int j = low; j < high; j++) {
            if (arr[j] < pivot) {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }

    void Sort(int[] arr, int low, int high) {
        if (low < high) {
            int pi = Partition(arr, low, high);
            Sort(arr, low, pi - 1);
            Sort(arr, pi + 1, high);
        }
    }

    static void PrintArray(int[] arr) {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    public static void Main(string[] args) {
        int[] arr = { 10, 7, 8, 9, 1, 5 };
        Console.WriteLine("Mảng ban đầu:");
        PrintArray(arr);

        QuickSort ob = new QuickSort();
        ob.Sort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nMảng đã sắp xếp:");
        PrintArray(arr);
    }
}

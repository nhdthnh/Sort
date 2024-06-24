using System;

class HeapSort {
    void Heapify(int[] arr, int n, int i) {
        int largest = i; 
        int l = 2 * i + 1; 
        int r = 2 * i + 2; 

        if (l < n && arr[l] > arr[largest])
            largest = l;

        if (r < n && arr[r] > arr[largest])
            largest = r;

        if (largest != i) {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            Heapify(arr, n, largest);
        }
    }

    void Sort(int[] arr) {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        for (int i = n - 1; i >= 0; i--) {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            Heapify(arr, i, 0);
        }
    }

    static void PrintArray(int[] arr) {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    public static void Main(string[] args) {
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Mảng ban đầu:");
        PrintArray(arr);

        HeapSort ob = new HeapSort();
        ob.Sort(arr);

        Console.WriteLine("\nMảng đã sắp xếp:");
        PrintArray(arr);
    }
}

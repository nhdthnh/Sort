using System;

class InsertionSort {
    static void Main(string[] args) {
        int[] arr = { 12, 11, 13, 5, 6 };
        int n = arr.Length;
        for (int i = 1; i < n; ++i) {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
        Console.WriteLine("Sorted array:");
        foreach (var item in arr)
            Console.Write(item + " ");
    }
}

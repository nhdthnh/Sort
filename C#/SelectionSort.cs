using System;

class SelectionSort {
    static void Main(string[] args) {
        int[] arr = { 64, 25, 12, 22, 11 };
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++) {
            int min_idx = i;
            for (int j = i + 1; j < n; j++) {
                if (arr[j] < arr[min_idx]) {
                    min_idx = j;
                }
            }
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
        Console.WriteLine("Sorted array:");
        foreach (var item in arr)
            Console.Write(item + " ");
    }
}

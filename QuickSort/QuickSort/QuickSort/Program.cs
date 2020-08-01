using System;

namespace QuickSort
{
    class Program
    {
        public static void Swap(int[] input, int l, int r)
        {
            int temp = input[l];
            input[l] = input[r];
            input[r] = temp;
        }

        public static int[] Quicksort(int[] input, int l, int r)
        {
            if (l < r)
            {
                int pivotIndex = Partition(input, l, r);
                Quicksort(input, l, pivotIndex - 1);
                Quicksort(input, pivotIndex + 1, r);
            }

            return input;
        }


        public static int Partition(int[] input, int l, int r)
        {
            int pivot = input[l];
            int pivotIndex = l;
            l++;

            while (l <= r)
            {
                if (input[l] > pivot)
                {
                    while (l <= r)
                    {
                        if (input[r] <= pivot)
                        {
                            Swap(input, l, r);
                        }

                        r--;
                    }
                }

                l++;
            }

            Swap(input, pivotIndex, r);

            return r;
        }

        static void Main(string[] args)
        {
            int[] input = { 6, 1, 5, 4, 22, 10, 7 };
            int[] output = Quicksort(input, 0, input.Length - 1);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}

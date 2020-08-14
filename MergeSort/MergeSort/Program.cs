using System;

namespace MergeSort
{
    public class Program
    {
        public static int[] MergeSort(int[] input, int start, int end)
        {
            if (start >= end)
            {
                return new int[] { input[end] };
            }

            int mid = (start + end) / 2;
            int[] left = MergeSort(input, start, mid);
            int[] right = MergeSort(input, mid + 1, end);

            int[] mergedArray = Merge(left, right);

            return mergedArray;
        }

        public static int[] Merge(int[] first, int[] second)
        {
            int[] mergedArray = new int[first.Length + second.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < first.Length && j < second.Length)
            {
                if (first[i] < second[j])
                {
                    mergedArray[k] = first[i];
                    i++;
                }
                else
                {
                    mergedArray[k] = second[j];
                    j++;
                }

                k++;
            }

            while (i < first.Length)
            {
                mergedArray[k] = first[i];
                i++;
                k++;
            }

            while (j < second.Length)
            {
                mergedArray[k] = second[j];
                j++;
                k++;
            }

            return mergedArray;
        }
        static void Main(string[] args)
        {
            int[] input = { 6, 2, 10, 1, 4, 3 };
            int[] output = MergeSort(input, 0, input.Length - 1);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}

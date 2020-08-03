using System;

namespace SelectionSort
{
    class Program
    {
        public static int GetMinIndex(int[] input, int start, int end)
        {
            int minIndex = start;

            for (int i = start; i <= end; i++)
            {
                if (input[i] < input[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int[] SelectionSort(int[] input)
        {
            int start = 0;
            int end = input.Length - 1;

            while (start<end)
            {
                int minIndex = GetMinIndex(input, start, end);

                int temp = input[start];
                input[start] = input[minIndex];
                input[minIndex] = temp;

                start++;

            }

            return input;
        }

        static void Main(string[] args)
        {
            int[] input = { 1, 10, 6, 2, 4, 5 };
            int[] output = SelectionSort(input);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}

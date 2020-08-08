using System;

namespace InsertionSort
{
    class Program
    {

        public static int[] InsertionSort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (input[j] < input[j - 1])
                    {
                        int temp = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return input;
        }

        static void Main(string[] args)
        {
            int[] input = { 10, 1, 6, 4, 2, 5 };
            int[] output =  InsertionSort(input);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}

using System;

namespace BubbleSort
{
    class Program
    {
        public static int[] BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j < input.Length-i; j++)
                {
                    if (input[j] < input[j - 1])
                    {
                        int temp = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = temp;
                    }
                }
            }

            return input;
        }

        static void Main(string[] args)
        {
            int[] input = {1, 10, 6, 2, 4, 5};
            int[] output = BubbleSort(input);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}

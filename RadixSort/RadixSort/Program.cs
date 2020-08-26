using System;
using System.Collections.Generic;

namespace RadixSort
{
    public class Program
    {
        public static int GetDigit(int number, int digitPlace)
        {
            int digit = 0;
            int counter = 0;

            while (number!=0)
            {
                digit = number % 10;
                counter++;

                if (counter == digitPlace)
                {
                    return digit;
                }

                number = number / 10;
            }

            return 0;
        }

        public static int[] RadixSort(int[] input)
        {
            //Identify largest number in the input
            int largestNumber = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > largestNumber)
                {
                    largestNumber = input[i];
                }
            }

            int length = largestNumber.ToString().Length;

            for (int i = 1; i <=length; i++)
            {
                Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();

                for (int j = 0; j < input.Length; j++)
                {
                    int digit = GetDigit(input[j], i);

                    if (dictionary.ContainsKey(digit))
                    {
                        dictionary[digit].Add(input[j]);
                    }
                    else
                    {
                        dictionary.Add(digit, new List<int>{input[j]});
                    }
                }

                int index = 0;
                //Add elements to input array
                for (int k = 0; k <= 9; k++)
                {
                    if (dictionary.ContainsKey(k))
                    {
                        List<int> list = dictionary[k];
                        
                        for (int m = 0; m < list.Count; m++)
                        {
                            input[index] = list[m];
                            index++;
                        }
                    }
                }
            }

            return input;
        }

        static void Main(string[] args)
        {
            int[] input = { 712, 834, 250, 9, 47, 681, 309 };
            int[] output =  RadixSort(input);

            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

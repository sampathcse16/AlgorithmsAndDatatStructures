using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubSequence
{
    class Program
    {
        public static int GetRightPosition(List<int> output, int value)
        {
            int l = 0;
            int r = output.Count - 1;

            while (l<=r)
            {
                int mid = (l + r) / 2;

                if (output[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return l;
        }

        public static bool IsElementExist(List<int> output, int value)
        {
            int l = 0;
            int r = output.Count - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (output[mid] == value)
                {
                    return true;
                }

                if (output[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return false;
        }
       
        public static List<int> LongestIncreasingSubSequence(int[] input)
        {
            List<int> output = new List<int>();
            Dictionary<int,int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (output.Count == 0)
                {
                    output.Add(input[i]);
                    dictionary.Add(input[i], Int32.MinValue);
                }
                else
                {
                    if (input[i] > output.Last())
                    {
                        output.Add(input[i]);
                        dictionary.Add(input[i], output[output.Count-2]);
                    }
                    else
                    {
                        if (!IsElementExist(output, input[i]))
                        {
                            int position = GetRightPosition(output, input[i]);
                            output[position] = input[i];
                            dictionary.Add(input[i], output[position - 1]);
                        }
                    }
                }
            }

            int lastElement = output.Last();
            List<int> finalResult = new List<int>();

            while (lastElement!=Int32.MinValue)
            {
                finalResult.Add(lastElement);
                lastElement = dictionary[lastElement];
            }

            return finalResult;
        }


        static void Main(string[] args)
        {
            int[] input = { 1, 2, 6, 10, 3 };
          List<int> finaList =LongestIncreasingSubSequence(input);

          for (int i = finaList.Count-1; i >=0; i--)
          {
              Console.WriteLine(finaList[i]);
          }
        }
    }
}

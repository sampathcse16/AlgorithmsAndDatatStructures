using System;

namespace HeapSort
{
    class Program
    {
        public static void Heapify(int[] input, int currentElementIndex, int lastIndex)
        {
            int leftChildIndex = 2 * currentElementIndex + 1;
            int rightChildIndex = 2 * currentElementIndex + 2;

            if (leftChildIndex > lastIndex)
            {
                return;
            } 

            int maxChildIndex = leftChildIndex;

            if (rightChildIndex<=lastIndex && input[rightChildIndex] > input[leftChildIndex])
            {
                maxChildIndex = rightChildIndex;
            }

            if (input[currentElementIndex] < input[maxChildIndex])
            {
                int temp = input[currentElementIndex];
                input[currentElementIndex] = input[maxChildIndex];
                input[maxChildIndex] = temp;

                Heapify(input, maxChildIndex, lastIndex);
            }
        }

        static void Main(string[] args)
        {
            int[] input = { 1, 12, 6, 5, 10, 3 };
            int lastIndex = input.Length - 1;
            
            for (int i = input.Length-1; i >=0; i--)
            {
                Heapify(input, i, lastIndex);
            }

            while (lastIndex>0)
            {
                int temp = input[0];
                input[0] = input[lastIndex];
                input[lastIndex] = temp;

                lastIndex--;

                Heapify(input, 0, lastIndex);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]+" ");
            }

            Console.WriteLine();
        }
    }
}

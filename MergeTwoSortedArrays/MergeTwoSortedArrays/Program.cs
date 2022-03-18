using System;

namespace MergeTwoSortedArrays
{
    class Program
    {
        public static int[] MergeTwoSortedArrays(int[] A, int[] B)
        {
            int[] C = new int[A.Length + B.Length];
        
            int indexA = 0;
            int indexB = 0;
        
            for (int i = 0; i < C.Length; i++)
            {
                if (indexA < A.Length && (indexB == B.Length || A[indexA] <= B[indexB]))
                {
                    C[i] = A[indexA];
                    indexA++;
                }
                else
                {
                    C[i] = B[indexB];
                    indexB++;
                }
            }
        
            return C;
        }

        static void Main(string[] args)
        {
            int[] A = {1, 5, 8, 10, 12};
            int[] B = {4, 7, 9, 11, 15};
            int[] C = MergeTwoSortedArrays(A, B);

            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine(C[i]);
            }

        }
    }
}

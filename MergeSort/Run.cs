using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class Run
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 6, 3, 5, 20, 84, 1, 2, 49, 29, 99, 38, 12, 18 };
            Write("I:", unsortedArray);
            MergeSort(unsortedArray, 0, unsortedArray.Length - 1);
            Write("O:", unsortedArray);
            Console.ReadLine();
        }

        private static void MergeSort(int[] unsortedArray, int LeftIndex, int RightIndex)
        {
            if (LeftIndex < RightIndex)
            {
                int MiddleIndex = (LeftIndex + RightIndex) / 2;
                MergeSort(unsortedArray, LeftIndex, MiddleIndex);
                MergeSort(unsortedArray, MiddleIndex + 1, RightIndex);
                Merge(unsortedArray, LeftIndex, MiddleIndex, RightIndex);
            }

        }

        private static void Merge(int[] UnsortedArray, int LeftIndex, int MiddleIndex, int RightIndex)
        {
            int LeftLength = MiddleIndex - LeftIndex + 1;
            int RightLength = RightIndex - MiddleIndex;
            int[] LeftArray = new int[LeftLength + 1];
            int[] RightArray = new int[RightLength + 1];

            for (int i = 0; i < LeftLength; i++)
                LeftArray[i] = UnsortedArray[LeftIndex + i];

            for (int j = 0; j < RightLength; j++)
                RightArray[j] = UnsortedArray[MiddleIndex + j + 1];

            LeftArray[LeftLength] = Int32.MaxValue;
            RightArray[RightLength] = Int32.MaxValue;
            int iIndex = 0;
            int jIndex = 0;
            for (int k = LeftIndex; k <= RightIndex; k++)
            {
                if (LeftArray[iIndex] <= RightArray[jIndex])
                {
                    UnsortedArray[k] = LeftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    UnsortedArray[k] = RightArray[jIndex];
                    jIndex++;
                }
            }

        }

        private static void Write(string prefix, int[] array)
        {
            Console.Write(prefix + " ");
            foreach (var item in array)
            {
                Console.Write(item.ToString() + ", ");
            }
            Console.WriteLine();
        }

        public string returnPath()
        {
            return Environment.CurrentDirectory;
        }
    }
}

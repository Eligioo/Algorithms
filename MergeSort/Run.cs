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

        private static void MergeSort(int[] unsortedArray, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;
                MergeSort(unsortedArray, leftIndex, middleIndex);
                MergeSort(unsortedArray, middleIndex + 1, rightIndex);
                Merge(unsortedArray, leftIndex, middleIndex, rightIndex);
            }
        }

        private static void Merge(int[] unsortedArray, int leftIndex, int middleIndex, int rightIndex)
        {
            int lengthLeft = middleIndex - leftIndex + 1;
            int lengthRight = rightIndex - middleIndex;
            int[] leftArray = new int[lengthLeft + 1];
            int[] rightArray = new int[lengthRight + 1];
            for (int i = 0; i < lengthLeft; i++)
            {
                leftArray[i] = unsortedArray[leftIndex + i];
            }
            for (int j = 0; j < lengthRight; j++)
            {
                rightArray[j] = unsortedArray[middleIndex + j + 1];
            }
            leftArray[lengthLeft] = Int32.MaxValue;
            rightArray[lengthRight] = Int32.MaxValue;
            int iIndex = 0;
            int jIndex = 0;
            for (int k = leftIndex; k <= rightIndex; k++)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    unsortedArray[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    unsortedArray[k] = rightArray[jIndex];
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

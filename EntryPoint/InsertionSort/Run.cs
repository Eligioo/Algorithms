using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class Run
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 3, 5, 20, 84, 1, 2, 49, 29, 99, 38, 12, 18 };
            Write("I:", array);
            for (int i = 1; i < array.Count(); i++)
            {
                int current = array[i];
                int previous = i - 1;
                while (previous >= 0 && current < array[previous])
                {
                    array[previous + 1] = array[previous];
                    previous--;
                }
                array[previous + 1] = current;
            }
            Write("O:", array);
            Console.ReadLine();
        }

        private static void Write(string prefix, int[] array)
        {
            Console.Write(prefix +" ");
            foreach (var item in array)
            {
                Console.Write(item.ToString() +", ");
            }
            Console.WriteLine();
        }

        public string returnPath()
        {
            return Environment.CurrentDirectory;
        }
    }
}
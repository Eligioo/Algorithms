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

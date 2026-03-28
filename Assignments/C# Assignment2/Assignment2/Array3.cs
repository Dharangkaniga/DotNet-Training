using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Array3
    {
        public static void Main()
        {
            Console.WriteLine("Enter Size:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] original_arr = new int[N];
            Console.WriteLine("\nEnter Elements:");
            for(int i=0;i<N;i++)
            {
                original_arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nOriginal Array Elements: ");
            for(int i=0;i<N;i++)
            {
                Console.Write(original_arr[i]+" ");
            }
            int[] copied_arr = new int[N];
            for(int j=0;j<N;j++)
            {
                copied_arr[j] = original_arr[j];
            }
            Console.WriteLine("\nCopied Array Elements:");
            for(int j=0;j<N;j++)
            {
                Console.Write(copied_arr[j]+" ");
            }
        }
    }
}

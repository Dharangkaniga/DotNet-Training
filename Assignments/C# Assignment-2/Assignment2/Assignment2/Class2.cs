using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Array1
    {
        public static void Main()
        {
            Console.WriteLine(" Enter Size Of Array: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            Console.WriteLine("Enter Elements: ");
            for(int i=0;i<N;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nElements in Array");
            for(int i=0;i<N;i++)
            {
                Console.WriteLine(arr[i]);
            }
            int min = arr.Min();
            Console.WriteLine($"Minimum Value in Array: {min}");
            int max = arr.Max();
            Console.WriteLine($"Maximum Value in Array: {max}");
            Console.ReadLine();


        }
    }
}

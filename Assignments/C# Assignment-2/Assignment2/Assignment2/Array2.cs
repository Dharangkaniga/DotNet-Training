using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Array2
    {
        public static void Main()
        {
            Console.WriteLine("Enter Size: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            int total = 0;
            float avg = 0;
            Console.WriteLine("\nEnter Marks");
            for(int i=0;i<N;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<N;i++)
            {
                total += arr[i];
            }
            Console.WriteLine($"\nTotal Marks:{total}");
            avg = total / N;
            Console.WriteLine($"Average Marks:{avg}");
            int min = arr.Min();
            Console.WriteLine($"\nMinimum Marks:{min}");
            int max = arr.Max();
            Console.WriteLine($"Maximum Marks:{max}");

            Array.Sort(arr);
            Console.WriteLine("\nAscending Order: ");
            for (int n = 0; n < N; n++)
            {
                Console.WriteLine(arr[n]);
            }
            Console.WriteLine("\nDescending Order:");
            for(int m=arr.Length-1;m>=0;m--)
            {
                Console.WriteLine(arr[m]);
            }

        }
        
    }
}

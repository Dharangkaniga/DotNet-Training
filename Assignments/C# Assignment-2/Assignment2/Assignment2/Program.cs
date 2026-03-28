using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Num / 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", Num);
                Console.WriteLine("{0}{0}{0}{0}", Num);
            }


        }
        
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class String_Length
    {
        static void Length(string word)
        {
            Console.WriteLine($"\nWord Length:{word.Length}");

        }
        static void Reverse(string word)
        {
            string rev = "";
            for(int i=word.Length-1;i>=0;i--)
            {
                rev += word[i];
            }
            Console.WriteLine($"\nReversed String:{rev}");
        }
        static void Equal(string word1,string word2)
        {
            if(word1==word2)
            {
                Console.WriteLine(" \nBoth Strings are EQUAL");
            }
            else
            {
                Console.WriteLine("\nBoth Strings are NOT EQUAL");
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter String1: ");
            string word1 = Console.ReadLine();

            Console.WriteLine("Enter String2: ");
            string word2 = Console.ReadLine();

            Length(word1.ToLower());
            Reverse(word1.ToLower());
            Equal(word1.ToLower(), word2.ToLower());



        }
    }
}

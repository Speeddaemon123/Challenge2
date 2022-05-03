using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static int ASCII_SIZE = 256;

        static void Main(string[] args)
        {
            #region "Challenge 2"
            Console.WriteLine("Please enter input string");
            String str = Console.ReadLine();
            Console.Write("Max occurring character is " +
                                getMaxOccurringChar(str.ToLower()));
            #endregion
            Console.ReadLine();
        }
         static char getMaxOccurringChar(String str)
        {
            // Create array to keep the count of
            // individual characters and
            // initialize the array as 0
            int[] count = new int[ASCII_SIZE];

            // Construct character count array
            // from the input string.
            int len = str.Length; //character
            for (int i = 0; i < len; i++)
                count[str[i]]++;

            int max = -1; // Initialize max count
            char result = ' '; // Initialize result

            // Traversing through the string and
            // maintaining the count of each character
            for (int i = 0; i < len; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }

            return result;
        }
    }

}

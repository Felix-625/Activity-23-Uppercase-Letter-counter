using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String sentence;

            Console.WriteLine("Enter a sentence:");
            sentence = Console.ReadLine();

            int uppercase = 0;

            // Loop through each character in the input string
            foreach (char c in sentence)
            {
                // Check if the character is an uppercase letter
                if (char.IsUpper(c))
                {
                    uppercase++;
                }
            }

            // Display the result
            Console.WriteLine("Total uppercase letters: " + uppercase);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for a word
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            // Prompt user for an index
            Console.Write("Enter an index (starting from 0): ");
            string indexInput = Console.ReadLine();

            // Validate input: check if it is a valid integer
            if (int.TryParse(indexInput, out int index))
                {
                // Check if the index is within the valid range
                if (index >= 0 && index < word.Length)
                {
                    // Retrieve and display the character at the specified index
                    char character = word[index];
                    Console.WriteLine($"Character at index {index}: {character}");
                }
                else
                {
                    Console.WriteLine("Error: Index is out of range.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid integer for the index.");
            }
        }
    }
}






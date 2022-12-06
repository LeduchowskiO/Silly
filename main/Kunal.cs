using System;

namespace Kunal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type any input
            Console.WriteLine("Input:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string input = Console.ReadLine();

            //replace all letters with kunal
            foreach (var letter in input)
            {
                string output = "";
                if (Char.IsLetter(letter))
                {
                    output += "Kunal";
                }
                else
                {
                    output += letter;
                }
            }

            Console.WriteLine(output);
        }
    }
}
using System;

namespace Kunal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type your username and press enter
            Console.WriteLine("Input:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string input = Console.ReadLine();

            foreach (var letter in input)
            {
                string output = "";
                if (Char.IsLetter(letter))
                {
                    output += "Kunal"
                }
                else
                {
                    output += letter;
                }
            }

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine(output);
        }
    }
}
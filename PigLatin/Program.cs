using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            string userInput = GetInput("Please input a word or sentence to translate to pig Latin");
            PigLatin pig = new PigLatin();
            string translation = pig.ToPigLatin(userInput);
            Console.WriteLine(translation);
            Console.WriteLine(pig.IsVowel('a'));
        }*/

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

       
    }
}

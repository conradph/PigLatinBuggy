using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PigLatin
{
    class PigLatin
    {
        

        public bool IsVowel(char c)
        {
            //meant to check whether a character is a vowel, looks like it doesn't work right now
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            return vowels.Contains(c);
        }

        public string ToPigLatin(string phrase)
        {
            string[] words = phrase.Split();
            string result = "";
            //i think we would need to split at spaces and loop through each word so that it works for last input test
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            foreach (string wordog in words)
            {
                bool asIs = false;
                string word = wordog.ToLower();
                //loop through each letter in the word and see if there are any special characters
                foreach (char c in specialChars)
                {
                    foreach (char w in word)
                    {
                        if (w == c)
                        {
                            Console.WriteLine("That word has special characters, we will return it as is");
                            //return word; // removed this line so that it would work with multiple words in phrase
                            asIs = true;
                        }
                    }

                }
                
                //check if there are vowels in the word, if there are not the word shouldn't change?
                bool noVowels = true;
                foreach (char letter in word)
                {
                    if (IsVowel(letter))
                    {
                        noVowels = false;
                    }
                }

                if (noVowels)
                {
                    asIs = true;
                }
                if (asIs)
                {
                    result += word;
                }
                else
                {
                    //if the first letter is a vowel, add 
                    char firstLetter = word[0];
                    string output = "placeholder";
                    if (IsVowel(firstLetter) == true)
                    {
                        output = word + "way";
                    }
                    else
                    {
                        //find the index of the first vowel
                        int vowelIndex = -1;
                        //Handle going through all the consonants
                        for (int i = 0; i <= word.Length; i++)
                        {
                            if (IsVowel(word[i]) == true)
                            {
                                vowelIndex = i;
                                break;
                            }
                        }
                        //Put the string back together based on where the first vowel is

                        string sub = word.Substring(vowelIndex); //Grabs the rest of the string after the first vowel
                        string postFix = word.Substring(0, vowelIndex); //Grabs the beginning of the string up to the first vowel

                        output = sub + postFix + "ay";
                    }
                    result += output;
                }
                if(wordog != words[words.Length-1])
                { 
                    result += " "; 
                }
                
            }

            return result;
        }
    }
}

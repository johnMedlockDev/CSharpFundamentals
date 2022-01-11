using System;

namespace WorkingWIthStringFunctions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string word = "Awesome";
            string word2 = "Awesome";
            string sentence = "Everything is ";
            
            // Primitives have helper methods for some common tasks.
            // Some useful string properties and methods:
            
            // Length = returns the number of characters in the string
            int length = word.Length;
            Console.WriteLine(length);
            
            // Contains = returns a boolean as to if a value exist in a string.
            bool contains = word.Contains('o');
            Console.WriteLine(contains);
            
            // Equals = Compares the value of the string and returns a boolean based on the result.
            bool equals = word.Equals(word2);
            Console.WriteLine(equals);
            
            // Insert = allows you to insert a value at a specific index of the string. (strings are really char arrays.)
            string word3 = "Awesome";
            word3 = word3.Insert(0, "All Things are ");
            Console.WriteLine(word3);
            
            // Remove = allows you to remove a value at a specific index of the string. (strings are really char arrays.)
            string word4 = "Awesome Things";
            word4 = word4.Remove(0);
            Console.WriteLine(word4);
            
            // Replace = Replaces a value if it exist in a string with another value.
            string word5 = "Awesome Things";
            word5 = word5.Replace(' ', '7');
            Console.WriteLine(word5);
            
            // Split = Creates a string array based on a separator (like a space.)
            string word6 = "Awesome Things";

            string[] words = word6.Split(" ");

            foreach (string splitWord in words)
            {
                Console.WriteLine(splitWord);
            }
            
            // Substring = Gives you the rest of a string from a certain starting index.
            string substring = sentence.Substring(5);
            Console.WriteLine(substring);
            
            // Trim = Removes whitespace at the beginning and end of a string.
            string wordWithSpaces = " Trimmed ";
            string wordWithoutSpaces = wordWithSpaces.Trim();
            Console.WriteLine(wordWithoutSpaces);
            
            // IndexOf = Returns the index of the first occurrence of a value passed in.

            int indexOf = wordWithSpaces.IndexOf('d');
            Console.WriteLine(indexOf);

            // StartsWith = returns a bool if it starts with a value passed in.
            bool startsWith = word.StartsWith('A');
            Console.WriteLine(startsWith);

            // EndsWith = returns a bool if it ends with a value passed in.
            bool endsWith = word.StartsWith('e');
            Console.WriteLine(endsWith);
            
            // ToLower = returns a copy of the string with all chars converted to lowercase.
            string upperWord = "AWESOME";
            string lowerWord = upperWord.ToLower();
            Console.WriteLine(lowerWord);
            
            // ToUpper = returns a copy of the string with all chars converted to uppercase.
            lowerWord = "awesome";
            upperWord = lowerWord.ToUpper();
            Console.WriteLine(upperWord);
            
            // ToCharArray = converts a string into a char array.
            char[] toCharArray = sentence.ToCharArray();

            foreach (char character in toCharArray)
            {
                Console.WriteLine(character);
            }

        }
    }
}

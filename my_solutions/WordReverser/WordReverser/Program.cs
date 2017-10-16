using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReverser
{
    // Create a function that takes a sentence as an input, reverses the letters in every word (but not reverses the words order in the sentence), and returns the sentence with the reversed words.
    // You shouldn't care about upper or lower case letters.
    // Example:
    //
    // string reversedWords = WordReverser("lleW ,enod taht saw ton taht drah");
    // Console.WriteLine(reversedWords);
    //
    // Should print:
    // Well done, that was not that hard

    class Program
    {
        static void Main(string[] args)
        {
            string reversedWords = WordReverser("lleW ,enod taht saw ton taht drah");
            Console.WriteLine(reversedWords);
            Console.ReadLine();
        }

        public static string WordReverser(string input)
        {
            string revWords = "";

            foreach (var word in input.Split(' '))
            {
                string temp = "";
                foreach (var character in word.ToCharArray())
                {
                    temp = character + temp;
                }
                revWords += temp + " ";
            }
            return revWords;
        }
    }
}

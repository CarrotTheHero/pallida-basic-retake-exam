using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Create a function that takes the filepath (e.g. "da_vinci_code.txt") as an input, reads the given file, and counts the occurences of 0, 1 and x characters in it.
// The function should return a dictionary in which the searched characters are the keys and the number of their occurences are the values.
// Use the uploaded da_vinci_code.txt file in this folder on GitHub to test your program.
// For example:
//
// var countedLetters = CountLetters("da_vinci_code.txt");
// Console.WriteLine("0 occured {0} times in the file.", countedLetters["0"]);
// Console.WriteLine("1 occured {0} times in the file.", countedLetters["1"]);
// Console.WriteLine("x occured {0} times in the file.", countedLetters["x"]);
// 
// Should print:
// 0 occured 3393 times in the file.
// 1 occured 3375 times in the file.
// x occured 3232 times in the file.

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var countedLetter0 = CountLetter0("da_vinci_code.txt");
            var countedLetter1 = CountLetter1("da_vinci_code.txt");
            var countedLetterX = CountLetterX("da_vinci_code.txt");

            Console.WriteLine("0 occured {0} times in the file.", countedLetter0);
            Console.WriteLine("1 occured {0} times in the file.", countedLetter1);
            Console.WriteLine("x occured {0} times in the file.", countedLetterX);
            Console.ReadLine();
        }

        private static object CountLetter0(string file)
        {
            int count = 0;

            using (var sr = new StreamReader(file))
            {
                while (sr.Read() == '0')
                    count++;
            }
            return count;
        }

        private static object CountLetter1(string file)
        {
            int count = 0;

            using (var sr = new StreamReader("da_vinci_code.txt"))
            {
                while (sr.Read() == '1')
                    count++;
            }
            return count;
        }
        private static object CountLetterX(string file)
        {
            int count = 0;

            using (var sr = new StreamReader("da_vinci_code.txt"))
            {
                while (sr.Read() == 'x')
                    count++;
            }
            return count;
        }
    }
}

using System;
using System.Linq;

namespace RemoveDuplicateChars 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string inputString = Console.Readline();
            string resultString = string.Empty;

            for (int i = 0 ; i < inputString.Length; i++)
            {
                if(!resultString.Contains(inputString[i]))
                {
                    resultString += inputString[i];
                }
            }
            Console.WriteLine(resultString);

            Console.ReadKey();
        }
    }
}
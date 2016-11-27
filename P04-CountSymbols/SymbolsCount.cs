//Write a program that reads some text from the console and counts the occurrences 
//of each character in it. Print the results in alphabetical (lexicographical) order. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class SymbolsCount
    {
        public static void Main()
        {
        string textToRead = Console.ReadLine();
        SortedDictionary<char, int> charOcc = new SortedDictionary<char, int>();
        for (int i = 0; i < textToRead.Length; i++)
        {
            char currentChar = textToRead[i];
            if (charOcc.ContainsKey(textToRead[i]) == false)
            {
                charOcc[currentChar] = 0;
            }
            charOcc[currentChar]++;
        }
        foreach (var kvp in charOcc)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SetsElements
    {
        static void Main()
        {
        string consoleInput = Console.ReadLine();
        string[] numberOfEntries = consoleInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        HashSet<int> firstSet = new HashSet<int>();
        HashSet<int> secondSet = new HashSet<int>();
        for (int i = 0; i < int.Parse(numberOfEntries[0]); i++)
        {
            firstSet.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < int.Parse(numberOfEntries[1]); i++)
        {
            secondSet.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> result = new HashSet<int>(firstSet.Intersect(secondSet));
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
        }
    }


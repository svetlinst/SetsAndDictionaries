//You are given an n number of chemical compounds. You need to keep track of all chemical 
//elements used in the compounds and at the end print all unique ones in ascending order:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class PerTable
    {
        public static void Main()
        {
        int numberOfElements = int.Parse(Console.ReadLine());
        SortedSet<string> elements = new SortedSet<string>();
        for (int i = 0; i < numberOfElements; i++)
        {
            string compound = Console.ReadLine();
            string[] elementsInCompound = compound.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < elementsInCompound.Length; j++)
            {
                elements.Add(elementsInCompound[j]);
            }
            
        }


        foreach (var item in elements)
        {
            Console.Write(item + " ");
        }

        }
    }


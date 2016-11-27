//You are given a sequence of strings, each on a new line. Every odd line on the console is representing a 
//resource (e.g. Gold, Silver, Copper, and so on) , and every even – quantity. Your task is to collect the resources
//and print them each on a new line. 
//Print the resources and their quantities in format:
//{resource} –> {quantity}
//The quantities inputs will be in the range[1 … 2 000 000 000]


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class MinersTask
    {
        public static void Main()
        {
        string consoleInput = Console.ReadLine();
        int iterations = 0;
        Dictionary<string, int> resources = new Dictionary<string, int>();
        string res = "";
        while (consoleInput != "stop")
        {
            
            if (iterations %2 == 0)
            {
                res = consoleInput;
            }
            else if (iterations%2 != 0)
            {
                if (resources.ContainsKey(res) == false)
                {
                    resources.Add(res, 0);
                }
                int currValue = resources[res];                
                resources[res] =currValue+ int.Parse(consoleInput);             
            }
            iterations++;
            consoleInput = Console.ReadLine();
        }
        foreach (var kvp in resources)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
        }
    }


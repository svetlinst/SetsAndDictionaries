using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class FixEmails
    {
        public static void Main()
        {
        string consoleInput = Console.ReadLine();
        int iteration = 0;
        Dictionary<string, string> usersEmail = new Dictionary<string, string>();
        string userName = "";
        while (consoleInput!="stop")
        {
            if (iteration%2 == 0)
            {
                if (usersEmail.ContainsKey(consoleInput)==false)
                {
                    usersEmail.Add(consoleInput, "");
                }
                userName = consoleInput;
            }
            else
            {
                string[] checkEmail = consoleInput.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                if (checkEmail[1]=="us" || checkEmail[1]=="uk")
                {
                    usersEmail.Remove(userName);
                }
                else
                {
                    usersEmail[userName] = consoleInput;
                }
                  
                     
            }
            iteration++;
            consoleInput = Console.ReadLine();
        }
        foreach (var kvp in usersEmail)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
        }
    }


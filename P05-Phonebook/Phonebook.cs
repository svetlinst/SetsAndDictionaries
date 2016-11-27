//Write a program that receives some info from the console about people and their phone numbers.
//You are free to choose the manner in which the data is entered; each entry should have just one name and 
//one number(both of them strings). If you receive a name that already exists in the phonebook, simply update its number.
//After filling this simple phonebook, upon receiving the command "search", your program should be 
//able to perform a search of a contact by name and print her details in format "{name} -> {number}". 
//In case the contact isn't found, print "Contact {name} does not exist." 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Phonebook
{
    public static void Main()
    {

        string consoleInput = Console.ReadLine();
        Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
        while (consoleInput != "search")
        {
            string[] nameAndNumber = consoleInput.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            if (phoneNumbers.ContainsKey(nameAndNumber[0]) == false)
            {
                phoneNumbers.Add(nameAndNumber[0], nameAndNumber[1]);
            }
            phoneNumbers[nameAndNumber[0]] = nameAndNumber[1];
            consoleInput = Console.ReadLine();
        }
        consoleInput = Console.ReadLine();
        while (consoleInput != "stop")
        {
            if (phoneNumbers.ContainsKey(consoleInput)==false)
            {
                Console.WriteLine($"Contact {consoleInput} does not exist.");
            }
            else
            {
                Console.WriteLine($"{consoleInput} -> {phoneNumbers[consoleInput]}");
            }
            consoleInput = Console.ReadLine();
        }
        
        }
    }


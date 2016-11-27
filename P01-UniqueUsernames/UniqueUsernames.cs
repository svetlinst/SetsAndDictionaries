using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class UniqueUsernames
    {
        public static void Main(string[] args)
        {
        HashSet<string> usernames = new HashSet<string>();
        int numberOfUsers = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfUsers; i++)
        {
            usernames.Add(Console.ReadLine());
        }
        foreach (var name in usernames)
        {
            Console.WriteLine(name);
        }

        }
    }


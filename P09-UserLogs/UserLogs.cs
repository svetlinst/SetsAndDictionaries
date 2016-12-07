using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class UserLogs
    {
        public static void Main()
        {
        string inputLine = Console.ReadLine();
        string ip = "";
        string message = "";
        string user = "";
        int attempts = 0;
        SortedDictionary<string, Dictionary<string, int>> log = new SortedDictionary<string, Dictionary<string, int>>();
        while (inputLine != "end")
        {
            ip = inputLine.Substring(3, inputLine.IndexOf(' ', 0)-3);            
            user = inputLine.Substring(inputLine.LastIndexOf('=')+1, (inputLine.Length - inputLine.LastIndexOf('=')-1));

            if (log.ContainsKey(user) == false)
            {
                log.Add(user, new Dictionary<string, int>());
                log[user].Add(ip, 0);              
            }
            else if (log[user].ContainsKey(ip)==false)
            {
                log[user].Add(ip, 0);
            }
            log[user][ip]++;       
            
            inputLine = Console.ReadLine();
        }

        foreach (var username in log)
        {
            Console.WriteLine("{0}:", username.Key);
            Console.WriteLine("{0}.", string.Join(", ", username.Value.Select(kv=>kv.Key + " => " + kv.Value)));
            
        }
    }
    }


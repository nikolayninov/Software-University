using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Data_Transfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var validationRegex = new Regex(@"(s:)([^;]*)(;).*(r:)([^;]*)(;).*(m--"")([a-zA-Z ]*)("")");
            
            var senderRegex = new Regex(@"(?<=s:)([^;]*)(?=;)");    
            var receiverRegex = new Regex(@"(?<=r:)([^;]*)(?=;)");
            var messageRegex = new Regex(@"(?<=m--"")([a-zA-Z ]*)(?=\"")");

            var nameRegex = new Regex(@"([a-zA-Z ])*");
            
            var digitRegex = new Regex(@"[\d]");

            int data = 0;
            int n = Int32.Parse(Console.ReadLine());
            var transfer = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string test = Console.ReadLine();

                if(validationRegex.IsMatch(test))
                {           

                    var senderMatch = senderRegex.Match(test).ToString();
                    var receiverMatch = receiverRegex.Match(test).ToString();
                    var messageMatch = messageRegex.Match(test).ToString();

                    string senderNameMatch = String.Join("",nameRegex.Matches(senderMatch));
                    string receiverNameMatch = String.Join("", nameRegex.Matches(receiverMatch));
                    

                    var dataMatch = String.Join("", digitRegex.Matches(senderMatch)) + String.Join("", digitRegex.Matches(receiverMatch));
                    foreach (var d in dataMatch)
                    {
                        data += Int32.Parse(d.ToString());
                    }

                    string line = $"{senderNameMatch} says \"{messageMatch}\" to {receiverNameMatch}";
                    transfer.Add(line);
                }                
            }
            foreach (var line in transfer)
            {
                System.Console.WriteLine(line);
            }
            System.Console.WriteLine($"Total data transferred: {data}MB");
                        
        }
    }
}

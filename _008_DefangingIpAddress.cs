using System;

namespace CodingChallenge
{
    public class Solution 
    {
        public static string DefangIpAddressUsingReplace(string address) 
        {
            return address.Replace(".", "[.]");
        }
        
        public string DefangIPaddr(string address) 
        {
            // Create new result
            var result = new StringBuilder();   
            
            foreach (var ch in address) {
                if (ch == '.') {
                    result.Append("[.]");
                } else {
                    result.Append(ch);
                }
            }        
            return result.ToString();
        }

        public static void Main(string[] args)
        {
            string address = "255.100.50.0";
            address = DefangIpAddressUsingReplace(address);
            Console.WriteLine("new address is {0}",address);
        }
    }
}
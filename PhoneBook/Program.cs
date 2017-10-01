using System;
using System.Collections.Generic;

namespace test3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            phoneBook.Add("John", 004512345678);
            phoneBook.Add("Smith", 003312345678);
            phoneBook.Add("Elane", 00131234567890);
            long phoneNumber = 1234;
            phoneBook.TryGetValue("John", out phoneNumber);
            /*
            if (phoneNumber != 0)
                Console.WriteLine("John's phone number is " + phoneNumber);
            else
                Console.WriteLine("We couldn't find the number you searched for :(");
            */

            Console.WriteLine("What are you searching for?");
            var searchTerm = Console.ReadLine();

            bool succes = false;
            foreach(KeyValuePair<string, long> item in phoneBook){
                if (searchTerm.ToLower() == item.Key.ToLower())
                {
                    Console.WriteLine(item.Key + "'s phone number is " + item.Value);
                    succes = true;
                }
            }
            if (succes == false)
            {
                Console.WriteLine(string.Format("The phone number for {0} is not in our book", searchTerm));
            }

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Dictionaries
    {
        public Dictionaries()
        {
            Console.WriteLine("Some examples of working with Dictionaries");
            Console.WriteLine("------------------------------------------");

            Dictionary<string, string> heroes = new Dictionary<string, string>();
            heroes.Add("Clark Kent", "Superman");
            heroes.Add("Bruce Wayne", "Batman");
            heroes.Add("Barry Allen", "The Flash");

            //Removing an item
            heroes.Remove("Barry Allen");

            //Number of items in dictionary and if it contains a specific key
            Console.WriteLine("Count : {0}", heroes.Count);
            Console.WriteLine("Clark Kent : {0}", heroes.ContainsKey("Clark Kent"));

            //Storing the value in a variable
            heroes.TryGetValue("Clark Kent", out string dicValue);
            Console.WriteLine($"Clark Kent : {dicValue}");
            Console.WriteLine("--------------------");

            //Printing the key and the value
            foreach (KeyValuePair<string,string> item in heroes)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            //Clears The Dictionary
            //heroes.Clear();
        }
    }
}

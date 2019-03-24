using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections.Collections
{
    public class HashTables
    {
        public HashTables()
        {
            Console.WriteLine("Some examples of working with Hashtables");
            Console.WriteLine("------------------------------------------");

            Hashtable table = new Hashtable();

            table.Add(100, "Peter");
            table.Add(101, "Ivan");
            table.Add(99, "Gosho");

            //automatically sorting the items in descending order
            foreach (int Id in table.Keys)
            {
                Console.WriteLine("Key : " + Id);
            }
            Console.WriteLine("-----------------");
            foreach (string name in table.Values)
            {
                Console.WriteLine("Value : " + name);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Item with key 101 : " + table[101]);
        }
    }
}

using Collections.Collections;
using System;
using System.Collections;

namespace Collections
{
    class Program 
    {
        static void Main(string[] args)
        {
            ArrayLists lists = new ArrayLists();
            Console.WriteLine("--------------------------------------------------------------------------------");

            Dictionaries dictionaries = new Dictionaries();
            Console.WriteLine("--------------------------------------------------------------------------------");

            Queues queues = new Queues();
            Console.WriteLine("--------------------------------------------------------------------------------");

            Stacks stacks = new Stacks();
            Console.WriteLine("--------------------------------------------------------------------------------");

            HashTables tables = new HashTables();
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.Read();
        }
    }
}

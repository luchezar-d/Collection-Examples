using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class ArrayLists
    {
        public ArrayLists()
        {
            Console.WriteLine("Some examples of working with ArrayLists");
            Console.WriteLine("----------------------------------------");
            ArrayList list = new ArrayList();

            list.Add("John");
            list.Add(10);
            list.Add(1.2);

            //The amount of items in the array list
            Console.WriteLine("Count : {0}", list.Count);
            //The capacity of the array list (it increases each time and item is added)
            Console.WriteLine("Capacity : {0}", list.Capacity);

            ArrayList list1 = new ArrayList();

            list1.AddRange(new object[] { "Mike", "Sally", "Dan" });

            //Adding from one array to the other
            list.AddRange(list1);

            //Sorting one type
            list1.Sort();
            list1.Reverse();
            
            //Inserting at index 1
            list1.Insert(1, "Smith");

            //New arraylist made out of 2 items from the second arraylist 0 is the start index and 2 is how many items from there
            ArrayList range = list1.GetRange(0, 2);

            //Iterating and arraylist
            foreach (object o in range)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("--------------------");
            //Removing the item at index 2
            list1.RemoveAt(3);
            foreach (object o in list1)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("--------------------");

            //Searching for Sally through the array
            Console.WriteLine("Index of Mike : {0}", list1.IndexOf("Mike"), 0);
            Console.WriteLine("--------------------");

            //Converting an arraylist into a string array
            string[] array = (string[])list1.ToArray(typeof(string));
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            
        }
    }
}

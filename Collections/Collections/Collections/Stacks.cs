using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Stacks
    {
        public Stacks()
        {
            Console.WriteLine("Some examples of working with Stacks");
            Console.WriteLine("------------------------------------");

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            foreach (object o in stack)
            {
                //Last in is printed out first
                Console.WriteLine($"Stack : {o}");
            }
            Console.WriteLine("--------------------");

            //Peek at the first item
            Console.WriteLine("Peek at the first item : {0}", stack.Peek());

            //Removes the first item
            Console.WriteLine("Pop the first item : {0}", stack.Pop());

            //Shows whether the stack contains an item
            Console.WriteLine("Contains item : {0}", stack.Contains(3));
            Console.WriteLine("--------------------");

            //Converting queue to array
            object[] numArray = stack.ToArray();
            Console.WriteLine(string.Join(", ", numArray));
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Queues
    {
        public Queues()
        {
            Console.WriteLine("Some examples of working with Queues");
            Console.WriteLine("------------------------------------");

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }

            //Checking if the Queue contains 1
            Console.WriteLine("Is 1 in Queue : {0}", queue.Contains(1));
            Console.WriteLine("--------------------");

            //Return removed item 
            Console.WriteLine("Removed 1 from Queue : {0}", queue.Dequeue());

            //Peeking at the first item after removing 1
            Console.WriteLine("Peek 1 from Queue : {0}", queue.Peek());

            //Converting queue to array
            object[] numArray = queue.ToArray();
            Console.WriteLine(string.Join(", ", numArray));
        }
    }
}

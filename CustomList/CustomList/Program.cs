using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        public static void Time(Action func)
        {
            var watch = new Stopwatch();

            watch.Start();
            func();
            watch.Stop();

            Console.WriteLine($"Elapsed : {watch.Elapsed}");
        }

        static void Main(string[] args)
        {
            //var list = new CustomList<int>();
            var list = new CustomList<CustomList<int>>();

            for (int i = 0; i < 1000; i++)
            {
                var newList = new CustomList<int>();
                newList.AddToTheEnd(4);
                newList.AddToTheEnd(i);
                list.AddToTheEnd(newList);
            }
            {
                var lastElement = list.Last;
                list.RemoveFromTheEnd();

                for (int i = 0; i < 100000000; i++)
                {
                    lastElement.AddToTheEnd(i);
                }
            }

            Console.Read();
            //Time(() => {
            //    list.Expand(100000000);

            //    for (int i = 0; i < 100000001; i++)
            //    {
            //        list.AddToTheEnd(i);
            //    }
            //    //Console.WriteLine(list.Catapcity);

            //    while (list.Size > 0)
            //    {
            //        list.RemoveFromTheEnd();
            //    }
            //    list.RemoveFromTheEnd();

            //    Console.WriteLine($"Should be -1 {list.Size}");
            //    list.AddToTheEnd(4);
            //});

        }
        
    }
    
}

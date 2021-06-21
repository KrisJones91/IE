using System;
using System.Collections.Generic;

namespace IE
{
    class ProgramTwo
    {
        static void Secondary(string[] args)
        {
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            // call GetCollection() with option == 2 which will return a Queue<int>
            // but we will store it in the base type of generic collections
            unknownCollection = GetCollection(2);
            Console.WriteLine("This was a Queue<int>");
            foreach(int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            unknownCollection = GetCollection(5);
            Console.WriteLine("This was an Array of int");
            foreach(int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            
        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numberList = new List<int>() {1, 2, 3, 4, 5};

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if(option == 1)
            {
                return numberList;
            }
            else if(option == 2)
            {
                return numberList;
            }
            else
            {
                return new int[] {11, 12, 13, 14, 15};
            }
        }
    }
}
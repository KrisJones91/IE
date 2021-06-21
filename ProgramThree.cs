using System;
using System.Collections.Generic;

namespace IE
{
    class ProgramThree
    {
        static void Three(string[] args)
        {
            // a list of type List<int> initialized with some number
            List<int> numberList = new List<int>() {8, 6, 2};
            //an array of type int[] intialized with some numbers 
            int[] numberArray = new int[] {1,7,1,4};
            //new line
            Console.WriteLine(" ");
            // call collectionSum() and pass the list to it
            CollectionSum(numberList);

            Console.WriteLine(" ");
            // call collectionSum() and pass the array to it
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            // sum variable to store the sum of the numbers in anyCollection
            int sum = 0;
            // for each number in the collection pased to this method
            foreach(int num in anyCollection)
            {
                sum += num;
            }
            //print the sum
            Console.Write("Sum is {0}", sum);
        }
    }
}
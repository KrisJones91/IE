using System;

namespace IE
{
    class Program
    {
        //1. IEnumerable <T> for generic collections
        //2. IEnumerable for non generic collections

        //<summary>
        //IEnumerable contains a single method that you MUST implement when implementing this interface
        //GetEnumerator(), which returns an IEnumerator<T> object
        //The returned IEnumerator<T> provides the ability to iterate through the collection
        //by exposing a current property that points at the object we are currently at in the collection
        //</summary>
        // <param name = "args"> </param>

        //When is it recommended to use the IEnumerable interface:
        // Your collection represents a massive database table
        // You don't want to copy the entire thing into memory and cause performance issues
        
        // When it is not recommended:
        // You need the results right away and are possibly mutating / editing the objects later on
        // In this case, it is better to use an Array or a List

        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            //iterate through list and check if we want to give treats
            foreach(Dog dog in shelter)
            {
                if(!dog.IsBad)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }
    }
}

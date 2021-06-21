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
        static void Main(string[] args)
        {
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;

namespace IE
{
    //this class contains a generic collection of ype Dog
    //objects of this class CAN'T be used inside a for each loop because it lacks an implementation of the IEnumerable interface
    class DogShelter : IEnumerable<Dog>
    {
        //list of type List<Dog>
        public List<Dog> dogs;
        
        //this constructor will initialize the dogs list with some values
        public DogShelter()
        {
            //initialize the dogs list using the collection-initializer
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Fido", true),
                new Dog("Butch", false),
                new Dog("Oreo", false),
                new Dog("Gus", false)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
            // throw new System.NotImplementedException();
        }
        //don't need to implement because Dog is not generic MUST KEEP but do nothing
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
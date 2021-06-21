using System.Collections.Generic;

namespace IE
{
    class DogShelter
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
    }
}
using System;

namespace IE
{
    class Dog
    {
        public string Name {get; set;}
        public bool IsBad {get; set;}
        public Dog(string name, bool isBad)
        {
            this.Name = name;
            this.IsBad = isBad;
        }

        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine("Dog: {0} said woof {1} times!", Name, numberOfTreats);
        }
    }
}
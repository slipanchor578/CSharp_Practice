using System;

namespace Sample
{
    class Dog : Animal
    {
        public Dog() : base("Dog"){}

        public override void Cry()
        {
            Console.WriteLine("Bow");
        }
    }
}
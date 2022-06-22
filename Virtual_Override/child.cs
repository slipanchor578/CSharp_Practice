using System;

namespace Sample
{
    class Child : Parent
    {
        public override void Foo()
        {
            Console.WriteLine("Child Foo");
        }

        public void Bar()
        {
            Console.WriteLine("Child Bar");
        }
    }
}
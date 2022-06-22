using System;

namespace Sample
{
    class Parent
    {
        public virtual void Foo()
        {
            Console.WriteLine("Parent Foo");
        }

        public void Bar()
        {
            Console.WriteLine("Parent Bar");
        }
    }
}
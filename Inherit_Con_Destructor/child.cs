using System;

namespace Sample
{
    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child Constructor :noargs");
        }

        public Child(int param) : base(param)
        {
            Console.WriteLine("Child Constructor :args={0}", param);
        }

        ~Child()
        {
            Console.WriteLine("Child Destructor: args={0}", this.param);
        }
    }
}
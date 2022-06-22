using System;

namespace Sample
{
    class Parent
    {
        protected int param = 0;

        public Parent()
        {
            Console.WriteLine("Parent Constructor :noargs");
        }

        public Parent(int param)
        {
            this.param = param;

            Console.WriteLine("Parent Constructor :args={0}", param);
        }

        ~Parent()
        {
            Console.WriteLine("Parent Destructor: args={0}", this.param);
        }

        protected internal void showParam()
        {
            Console.WriteLine("param = {0}", this.param);
        }
    }
}
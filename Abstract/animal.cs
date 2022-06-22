using System;

namespace Sample
{
    abstract class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get {return this.name;}
        }

        public abstract void Cry();
    }
}
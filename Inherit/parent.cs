using System;

namespace Sample
{
    class Parent
    {
        protected int num1;

        protected int num2;

        public int Num1
        {
            set {this.num1 = value;}
            get {return this.num1;}
        }

        public int Num2
        {
            set {this.num2 = value;}
            get {return this.num2;}
        }

        public void Add()
        {
            Console.WriteLine("{0} + {1} = {2}", this.num1, this.num2, this.num1 + this.num2);
        }

        public void Sub()
        {
            Console.WriteLine("{0} - {1} = {2}", this.num1, this.num2, this.num1 - this.num2);
        }
    }
}
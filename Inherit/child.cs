using System;

namespace Sample
{
    class Child : Parent
    {
        public void Mul()
        {
            Console.WriteLine("{0} * {1} = {2}", this.num1, this.num2, this.num1 * this.num2);
        }

        public void Div()
        {
            Console.WriteLine("{0} / {1} = {2}", this.num1, this.num2, this.num1 / this.num2);
        }
    }
}
using System;

namespace Sample
{
    class Program
    {
        static void Main()
        {
            var p1 = new Parent();

            p1.Num1 = 10;
            p1.Num2 = 3;

            p1.Add();
            p1.Sub();

            var p2 = new Child();

            p2.Num1 = 10;
            p2.Num2 = 3;

            p2.Add();
            p2.Sub();
            p2.Mul();
            p2.Div();
        }
    }
}
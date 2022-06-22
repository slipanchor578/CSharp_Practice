using System;

namespace Sample
{
    class Program
    {
        private void Bar()
        {
            Console.WriteLine("Bar");
        }

        private static void Main()
        {
            var p = new Program();

            p.Bar();

            Console.WriteLine("{0}", p.GetHashCode());
            Console.WriteLine("{0}", p.ToString());
        }
    }
}

/*
    結果:

    Bar
    46104728   
    Sample.Program

    ProgramクラスのメソッドとしてBarメソッドを実装しているので当然呼び出すことができる
    しかし、実装していないGetHashCodeメソッドやToStringメソッドまでProgramクラスから呼び出すことができる

    これは全てのクラスがSystem.Objectを継承しているから
    当然、Programクラス内でoverrideすれば、自分の好きなToStringメソッドを実装できたりする
*/
using System;

namespace Sample
{
    class Program
    {
        private static void Main()
        {
            // var a = new Animal(); // 抽象クラスのインスタンス化はできない

            var d = new Dog();

            Console.Write("name: {0} ", d.Name);
            d.Cry();

            var c = new Cat();

            Console.Write("name: {0} ", c.Name);
            c.Cry();
        }
    }
}

/*
    結果:

    name: Dog Bow
    name: Cat Mew

    1つのクラスを元に、同じような機能を持つ複数のクラスを作りたい場合は抽象クラスを使う
    今回の例では、普通にAnimalクラスを基底クラスとして派生クラスDog、Catクラスを作る場合は
    Animalクラスのインスタンスまで生成されてしまう。
    抽象クラスにすればインスタンス生成はされなくなり無駄がなくなる
    abstractを付けたメソッドは派生クラス側で定義を行う必要がある。仮に派生クラス側で抽象メソッドを実装し忘れていると
    コンパイルエラーで警告してくれる

    決められた機能だけは実装してくれたら、後は自由に改変できるのが抽象クラスとなる
*/
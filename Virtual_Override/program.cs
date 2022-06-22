using System;

namespace Sample
{
    class Program
    {
        private static void Main()
        {
            Parent p = new Parent();

            Parent pc = new Child();

            p.Bar();

            pc.Bar();

            p.Foo();

            pc.Foo();
        }
    }
}

/*
    結果:

    Parent Bar
    Parent Bar
    Parent Foo
    Child Foo

    子クラスの参照を使って親クラスの型でインスタンスを作成した場合呼び出される同名のメソッドは
    親クラスのものが優先される

    親クラスの同名メソッドに「virtual」修飾子を付けて、子クラスで「override」修飾子を付けて
    上書きすると、同じように呼び出しても子クラスの方の同名メソッドを呼び出してくれる
*/
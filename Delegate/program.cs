using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample
{
    // 引数を取らず戻り値を返さないデリゲート型を作る
    delegate void Hello_Delegate();

    class Program
    {

        public static void Main()
        {
            // 普通の関数呼び出し
            Hello();

            // 同じ引数、同じ戻り値の関数をデリゲート変数に入れて呼び出せる
            Hello_Delegate h1 = Hello;

            // デリゲートを用いて関数呼び出し
            h1();

            // 匿名メソッドを使えば、その場でデリゲートに対して関数を記述できる
            // わざわざデリゲートで使うための関数をクラス内に定義する必要がない
            Hello_Delegate h2 = delegate(){Console.WriteLine("h2 delegate anonymous method");};

            // デリゲート + 匿名メソッド による関数呼び出し
            h2();

            // ラムダ式によるデリゲートへの代入。いちいち「delegate()」のような事をせずに
            // 直接記述できるようになった
            Hello_Delegate h3 = () => Console.WriteLine("h3 delegate Lambda expression");

            // デリゲート + ラムダ式 による関数呼び出し
            h3();

            // わざわざ「delegate 戻り値 デリゲート関数名 (引数)」なんて書くのは面倒なので
            // 新しく引数、戻り値に応じたデリゲート型が用意された
            // 戻り値を返さない時は「Action」型を使えば良い
            Action h4 = () => Console.WriteLine("Action type Lambda Expression");

            // Action型デリゲート による関数呼び出し
            h4();

            var list = new List<int>{1,2,3,4,5,6,7,8,9,10};

            // Linq拡張メソッドにはラムダ式を渡すことができる
            // 偶数を取り出すラムダ式
            var ier = list.Where(x => x % 2 == 0).Select(x => x);

            foreach(var item in ier)
            {
                Console.Write("{0} ", item.ToString());
                // 2 4 6 8 10
            }

            Console.Write('\n');

            // 引数、戻り値どちらも必要な場合はFunc型デリゲートを作る
            // 奇数の場合はtrueを返す関数
            Func<int, bool> f1 = (x) => x % 2 != 0;

            // 条件に応じた自分で作ったデリゲートを渡すことができる
            // 好きな条件でリストを操作できる
            var ier2 = list.Where(f1).Select(x => x);

            foreach(var item in ier2)
            {
                Console.Write("{0} ", item.ToString());
                // 1 3 5 7 9
            }

            Console.Write('\n');

            // 引数を取り、条件に応じてboolを返すPredicate型デリゲート
            Predicate<int> p1 = (x) => x > 5;

            // リストの中から最初に見つけた「5より大きい数字」を返す
            var result = list.Find(p1);

            Console.WriteLine(result); // 6
        }

        static void Hello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
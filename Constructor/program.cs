using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample
{
    public class Program
    {
        static void Main()
        {
            Person p1;
            Person p2;

            p1 = new Person();
            p2 = new Person("Bob", 29);

            p1.show_Age_And_Name();
            p2.show_Age_And_Name();

            Console.WriteLine("name: {0}, age: {1}", p2.Name, p2.Age);
        }
    }
}

/*
    結果:

    引数ありコンストラクタ。name:John Doe age: 0
    引数なしコンストラクタ
    引数ありコンストラクタ。name:Bob age: 29
    名前: 名無し, 年齢: 0
    名前: Bob, 年齢: 29
    名前: Bob, 年齢: 29

    p1は引数を与えていないが、this初期化子を使って("John Doe", 0)と引数を与えているため
    引数ありコンストラクタに処理が移る。そこでフィールドに値が設定され
    「引数ありコンストラクタ。name:John Doe age: 0」と出力される
    終わると元の引数なしコンストラクタに処理が移り
    「引数なしコンストラクタ」と出力される。引数を与えていないからといって、this初期化子を使っていると
    「引数ありコンストラクタ」に処理が飛ぶことに注意

    p2は引数を与えているため最初から引数ありコンストラクタに処理が移る

    ちなみに
    private string name = String.Empty;
    private int age = 0;

    としてコンストラクタ呼び出し以前から値を設定している。これを変数初期化子という。
    変数初期化子 -> this初期化子 -> コンストラクタ
    の順で処理ステージが分けられている
    変数初期化子のタイミングで「name = "", age = 0」と値が設定されているといっても
    「引数ありコンストラクタ」が呼ばれるわけではない
    インスタンス生成時の
    p1 = new Person() or new Person(x, y);
    としたタイミングで初めて、引数の数によってどちらのコンストラクタが呼び出されるか処理が分かれる
*/
using System;

namespace Sample
{
    class Program
    {
        static void Main()
        {
            Dummy d = new Dummy();
        }
    }
}

/*
    結果:

    コンストラクタ
    デストラクタ


    インスタンスが生成される時にコンストラクタが呼び出されるが
    デストラクタはインスタンスが破棄される時に呼び出される。明示的に呼び出せるものではない
    Mainメソッドを抜ける時にインスタンスが破棄されて、デストラクタが呼び出される
*/
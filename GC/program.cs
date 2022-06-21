using System;

namespace Sample
{
    class Program
    {
        static void Main()
        {
            String[] array = new String[10000];

            for(int i = 0; i < 10000; ++i)
            {
                array[i] = new String('M', 10000);
            }

            Console.WriteLine("メモリ使用量 (GC発動前) : {0}", GC.GetTotalMemory(false).ToString());

            array = null;

            Console.WriteLine("メモリ使用量 (参照の解除後) : {0}", GC.GetTotalMemory(false).ToString());

            GC.Collect();

            Console.WriteLine("メモリ使用量 (GC発動後) : {0}", GC.GetTotalMemory(false).ToString());
        }
    }
}

/*
    結果:

    メモリ使用量 (GC発動前) : 200445656
    メモリ使用量 (参照の解除後) : 200462040
    メモリ使用量 (GC発動後) : 56232


    String[] array = new String[10000];

    10000個のstring型配列を作っている

    for(int i = 0; i < 10000; ++i)
    {
        array[i] = new String('M', 10000);
    }

    string型のインスタンスを10000個作っている。
    new String('M', 10000);
    とすることで「'M'が10000個連続する文字列のstring型インスタンス」を作っている
    string型配列arrayは、10000文字のstringインスタンスを10000個持つことになる

    GC.GetTotalMemory(boolean);
    現在マネージドメモリに割り当てられているバイト数の最もよい「近似値」となる数値を返す。厳密な値ではないことに注意
    (true)を入れて実行するとGCを実行した後でメモリ使用量を返す。(false)を入れて実行するとGCを行わずそのままの状態でメモリ使用量を返す
    最初のGetTotalMemoryメソッド実行時には、まだ変数arrayに参照先のアドレスが束縛されているのでGCは発生しない

    その後
    array = null;
    として変数arrayへの大量のメモリの参照を外す。この時点でもいきなりGCが発動するわけではない

    GC.Collectメソッドを実行することで強制的にガベージコレクションを発生させる
    10000文字のstring型インスタンスが10000個入った配列が専有しているメモリ群は、「array = null」とすることで
    参照されなくなっているため、CLR(Common Language Runtime)がこれを感知し、メモリの解放を行う。
    この後のGetTotalMemoryメソッド実行時には大幅にマネージドメモリ使用量が減少していることが分かる

    メモリ使用量 (GC発動前) : 200445656
    メモリ使用量 (参照の解除後) : 200462040
    メモリ使用量 (GC発動後) : 56232

    200445656 = 約200.4MBがヒープメモリとして専有されている

    10000個の要素数の配列なので
    「200000000 / 10000 = 20000Byte」
    1つのstringインスタンスは10000文字なので
    「20000 / 10000 = 2Byte」
    C#はUTF16が使われているので1文字を2Byteで管理している

    ヒープメモリとして割り当てられたメモリがちゃんと回収されていることが分かる
*/
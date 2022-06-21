using System;

namespace Sample
{
    class Program
    {
        static void Main()
        {
            Data[] array = new Data[3];

            Data.show_Number();

            for(int i = 0; i < array.Length; ++i)
            {
                array[i] = new Data(i * 100);

                Data.show_Number();
            }
        }
    }
}

/*
    結果:

    Dataオブジェクトの数: 0
    値: 0 数: 1
    Dataオブジェクトの数: 1
    値: 100 数: 2
    Dataオブジェクトの数: 2
    値: 200 数: 3
    Dataオブジェクトの数: 3


    静的フィールド、静的メソッドはインスタンスではなくクラスに紐づいているので
    インスタンスを生成しなくても参照できるし呼び出すことができる

    最初のData.show_Numberメソッド呼び出し時の時点では、まだ1つもDataインスタンスを生成していないので
    Data.num = 0 のままになっている

    その後確保したメモリ先に対して3つのDataインスタンスを生成する
    array[i] = new Data(i * 100);

    コンストラクタ呼び出しされるたびに
    「値: 0 数: 1」のように表示され、Data.show_Numberメソッド呼び出しすると
    Data.numがインスタンス生成分増加していることが分かる
    Data.num = 0 -> 3

    「生成されたxxxインスタンスの合計の数」のように、インスタンスで管理するのではなく
    クラスで管理したほうがよさそうなフィールドやメソッドは静的フィールド/メソッドにしたほうが使用メモリも減らせるし
    クラスで一元的に管理できるからお得

    仮にData.numをインスタンスが持つとしたら、今回は3つ分インスタンスを生成したので3つ分のメモリ領域が余分に必要になる
    これをクラスで管理する場合、どれだけインスタンスが増えてもクラスで管理する1つ分のメモリ領域だけで済む
*/
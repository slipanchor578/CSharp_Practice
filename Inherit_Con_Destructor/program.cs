using System;

namespace Sample
{
    class Program
    {
        static void Main()
        {
            var c1 = new Child();

            c1.showParam();

            var c2 = new Child(100);

            c2.showParam();
        }
    }
}

/*
    結果:

    Parent Constructor :noargs
    Child Constructor :noargs
    param = 0
    Parent Constructor :args=100
    Child Constructor :args=100
    param = 100
    Child Destructor: args=100  
    Parent Destructor: args=100 
    Child Destructor: args=0    
    Parent Destructor: args=0

    
    var c1 = new Child();
    まずChildインスタンスを生成する。ChildクラスはParentクラスを継承しているので
    先にParentクラスの引数なしコンストラクタを呼び出す
    その後にChildクラスの引数なしコンストラクタを呼び出す
    Parentクラスを継承しているのでc1インスタンスはParentクラスのインスタンスメソッドshowParamを呼び出すことができる

    var c2 = new Child(100);
    次に引数有りでChildインスタンスを作成する。引数有りのChildコンストラクタが呼び出される前に
    base修飾子を使ってParentクラスの引数有りコンストラクタを呼び出しているので、まずそちらに処理が移る
    よって「Parent Constructor :args=100」と表示される
    その後にChildクラスの引数有りコンストラクタに処理が戻り「Child Constructor :args=100」と表示される

    コンストラクタ呼び出しでは親クラス、子クラスの順で呼び出されるが、デストラクタ呼び出しはその逆で
    子クラス、親クラスの順で呼び出される

    最後にインスタンスを生成した順でデストラクタ呼び出しされるのでc2、c1インスタンスの順で破棄される

    Child Destructor: args=100  
    Parent Destructor: args=100

    と子クラス、親クラスの順でデストラクタ呼び出しされているのが分かる
*/
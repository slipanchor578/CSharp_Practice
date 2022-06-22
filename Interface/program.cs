using System;
using System.Linq;
using System.Collections.Generic;

namespace Sample
{
    interface Func1
    {
        IEnumerable<int> enumerator(ref int[] array, Predicate<int> pred);
    }

    class Program : Func1
    {
        public IEnumerable<int> enumerator(ref int[] array, Predicate<int> pred)
        {
            var list = new List<int>();

            foreach(var item in array)
            {
                if(pred(item))
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public static void Main()
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10};

            Predicate<int> pred = n => n % 2 == 0;

            var p = new Program();

            var result = p.enumerator(ref array, pred);

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/*
    結果:

    2
    4
    6
    8
    10

    インターフェイスは抽象クラスや抽象メソッドを更に推し進めたもの
    抽象メソッドの集まりのような感じ
    インターフェイスを継承したクラスは、インターフェイス内のメソッドを全て実装しないといけない
    
    継承による親子クラスの関係性や、抽象クラスを継承したクラス間の横の緩やかな繋がりと比べて
    より疎結合のクラスを設計できる。インターフェイスを付けたり外すだけで継承やoverrideしなくても
    機能を増やせる

    どんなクラスに継承させたとしてもインターフェイスが持つメソッドは同じなので、同じ機能を期待できる
    抽象クラスに比べると管理が楽。メソッドを持たせるだけなので
*/
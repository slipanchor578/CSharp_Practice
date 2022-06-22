using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample
{
    class Program
    {
        public static void Main()
        {
            var list = new List<int>{1,2,3,4,5,6,7,8,9,10};

            for(int i = 0; i < list.Count; ++i)
            {
                // インデックス呼び出し
                Console.Write("{0} ", list[i]);
            }

            Console.Write('\n');

            // 要素の順序を反転させる
            list.Reverse();

            // foreachによる呼び出し
            foreach(var item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.Write('\n');

            Console.WriteLine(list[0]); // 破壊的変更なので「10」

            // list内から検索
            var result = list.Find(x => x == 1);

            Console.WriteLine("smallest number is {0}", result); // 1

            //IEnumerable<string>を作る
            var list2 = list.Where(x => x % 2 == 0)
                            .OrderBy(x => x)
                            .Select(x => x.ToString() + ".txt");

            foreach(var item in list2)
            {
                Console.Write("{0} ", item); // x.txt が出力される
            }

            Console.Write('\n');

            // 存在するかチェック
            Console.WriteLine("「0」は入っていますか？ {0}", list.Exists(x => x == 0));

            // listの要素を全削除

            list.Clear();

            Console.Write(list.Count == 0 ? "削除できました" : "削除できていません");

            Console.Write('\n');

            // HashSetは要素の重複を許さないリストみたいなもの
            var hash = new HashSet<int>();

            hash.Add(1);
            hash.Add(2);
            hash.Add(3);
            hash.Add(1); // setされない

            foreach(var item in hash)
            {
                Console.WriteLine(item); // 1 2 3
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample
{
    class Program
    {
        public static void Main()
        {
            var dic = new Dictionary<string, string>{
                {"red", "apple"},
                {"blue", "blueberry"},
                {"yellow", "banana"}
            };

            Console.WriteLine(dic["red"]); // apple

            // Dictionaryはインデックスで要素を管理しない。よってforeachで列挙する
            foreach(var item in dic.Keys)
            {
                Console.WriteLine(item); // red blue yellow
            }

            foreach(var item in dic.Values)
            {
                Console.WriteLine(item); // apple blueberry banana
            }

            // キーと値のペア
            foreach(KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("Key: {0} Value: {1}", item.Key, item.Value);
            }

            // redキーを持つ要素を削除
            dic.Remove("red");

            // キー : red がDictionary内にあるかチェック
            if(!dic.ContainsKey("red"))
            {
                Console.WriteLine("「キー: red」の要素は削除されました");
            }
            else
            {
                Console.WriteLine("「キー: red」の要素は削除されていません");
            }
        }
    }
}
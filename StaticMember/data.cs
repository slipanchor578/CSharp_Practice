using System;

namespace Sample
{
    class Data
    {
        private static int num = 0;

        private int id;

        public Data(int id)
        {
            this.id = id;
            num++;
            Console.WriteLine("値: {0} 数: {1}", this.id, Data.num);
        }

        public static void show_Number()
        {
            Console.WriteLine("Dataオブジェクトの数: {0}", Data.num);
        }
    }
}
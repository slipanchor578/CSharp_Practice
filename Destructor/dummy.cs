using System;

namespace Sample
{
    class Dummy
    {
        public Dummy()
        {
            Console.WriteLine("コンストラクタ");
        }

        ~Dummy()
        {
            Console.WriteLine("デストラクタ");
        }
    }
}
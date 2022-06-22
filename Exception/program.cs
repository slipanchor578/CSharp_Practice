using System;

namespace Sample
{

    class Program
    {

        public static void Main()
        {
            var a = 6;
            
            var b = 0;

            Console.WriteLine(a / b);

            Console.WriteLine("ここは表示されない");

            // 0除算したので「DivideByZeroException例外」が発生した
            // 何もしていないのでプログラムが終了してしまい、次の行以降は処理されなくなってしまう
            // ハンドルされていない例外: System.DivideByZeroException: 0 で除算しようとしました。
            // 場所 Sample.Program.Main()
        }
    }
}
using System;

namespace Sample
{

    class Program
    {

        public static void Main()
        {
            var a = 6;
            
            var b = 0;

            try
            {
                // try句内で例外が発生した場合、catch句でキャッチできる場合はcatch句に移動する
                Console.WriteLine(a / b);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                // 0 で除算しようとしました。
            }

            try
            {
                Console.WriteLine(a / b);
            }
            // Exceptionクラスは全ての例外の基礎クラスなので、これでも受け取れる
            catch(Exception e)
            {
                Console.WriteLine("Exceptionクラスは全ての例外クラスの基礎クラス");
            }

            try
            {
                Console.WriteLine("例外発生しません");
            }
            catch
            {
                Console.WriteLine("例外が投げられていないのでcatch句にも突入しない");
            }
            // 例外が有っても無くてもfinally句があれば突入するので必ず実行したい処理をここで書く
            finally
            {
                Console.WriteLine("finally句には何があっても突入する");
            }
        }
    }
}

/*
    try~catch~finally句を記述しておけば、例外発生した時もキャッチして
    処理を実行することができる。プログラムが強制終了することと、最後まで実行する差は非常に大きい

    そもそも例外発生しないように記述することが一番大事
*/
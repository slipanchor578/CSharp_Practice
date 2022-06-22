using System;

namespace Sample
{

    class Program
    {

        public static void Main()
        {
            try
            {
                Throw_Error();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // 自分で例外を投げることも可能
        static void Throw_Error()
        {
            throw new Exception("例外は明示的に投げることも可能");
        }
    }
}
using System;

namespace Sample
{
    class Cat : Animal
    {
        public Cat() : base("Cat"){}

        /*
        public override void Cry()
        {
            Console.WriteLine("Mew");
        }*/
    }
}

/*
    Animalクラスを継承しているにも関わらずCryメソッドをオーバーライドしていないと
    「Sample.Cat' は継承抽象メンバー 'Sample.Animal.Cry()' を実装しません。」
    と警告が出てコンパイルできない。
*/
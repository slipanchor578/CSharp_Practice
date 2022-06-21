using System;

namespace Sample
{
    public class Person
    {
        private string name = String.Empty;
        private int age = 0;

        public Person() : this("John Doe", 0)
        {
            Console.WriteLine("引数なしコンストラクタ");
        }
        
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("引数ありコンストラクタ。name:{0} age: {1}", name, age);
        }

        public void show_Age_And_Name()
        {
            Console.WriteLine("name: {0}, age: {1}", this.name, this.age);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }
    }
}
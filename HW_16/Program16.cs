using System;

namespace HW_16
{
    class Program16
    {
        /*Cоздать класс Dog, где описать характеристики и поведение собаки, а потом вызвать этот класс из MainTest класса.*/
        class Dog
        {


            public string name = "Snejok";
            public int age = 1;
            public string weight = "3 kg";
            public string character = "introvert";

            string a = "test";
            string b = "test1";
            static string Move(string a, string b)
            {
                string results = a + b;
                return results;
            }
        }
        class MainTest
        {
            static void Main(string[] args)
            {
                Dog test = new Dog();
                Console.WriteLine(test.name);
                Console.WriteLine(test.age);
                Console.WriteLine(test.weight);
                Console.WriteLine(test.character);
                Console.WriteLine(test.);
            }
        }
    }
}

        
        



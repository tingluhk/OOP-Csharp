using System;

namespace Console01
{
    class Program
    {
        static void Main(string[] args)
        {
            Method01(22,"john");
        }

        public static void Method01(int Age, string Name){
            Person person01 = new Person();
            person01.Name = Name;
            person01.Age = Age;
            System.Console.WriteLine($"my name is {person01.Name}, my age is {person01.Age}");
        }
    }
}

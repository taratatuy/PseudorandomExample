using System;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                SomeClass SC = new SomeClass();
                SomeMethod();
                Console.ReadLine();
            }
        }

        private static void SomeMethod()
        {
            Random random = new Random();

            int roll = random.Next(100);

            Console.WriteLine($"{roll}");
        }
    }
}

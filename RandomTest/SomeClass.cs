using System;

namespace RandomTest
{
    class SomeClass
    {
        public SomeClass()
        {
            SomeMethod();
        }

        private void SomeMethod()
        {
            Random random = new Random();

            int roll = random.Next(100);

            Console.WriteLine($"{roll}");
        }
    }
}

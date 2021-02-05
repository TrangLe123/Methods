using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Hello_user(userName);
        }

        private static void Hello_user(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}



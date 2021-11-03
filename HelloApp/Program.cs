using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            HelloWhite();
            GreetBlack();
        }

        static void HelloWhite ()
        {
            Console.WriteLine("hello white");
        }

        static void GreetBlack ()
        {
            Console.WriteLine("hello black");
        }
    }
}

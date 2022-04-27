using System;

namespace iSMAControlli
{
    class Program
    {
        static void Main(string[] args)
        {
            // This works only when I know that someNumber is always a Int number
            Console.WriteLine(IsNumberDevideByTwo(Convert.ToInt32(Console.ReadLine())));

            Console.ReadKey();
        }

        static bool IsNumberDevideByTwo(int someNumber)
        {
            if(someNumber % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}

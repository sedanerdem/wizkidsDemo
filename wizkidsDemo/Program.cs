using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizkidsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 : palindrome strings
            Console.WriteLine("Task1: Enter palindrome string : ");
            bool isPalindrome = palindrome(Console.ReadLine());
            Console.WriteLine(isPalindrome);
            Console.ReadKey();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Task2: FooBar");
            fooBar();
            Console.ReadKey();
            Console.WriteLine("----------------------------------");

            Console.ReadKey();
        }


        public static bool palindrome(string s)
        {
            bool isPalindrome = true;
            int checkCount = (s.Length % 2 == 0) ? s.Length / 2 : (s.Length - 1)/2;
            for (int i = 0, j = s.Length-1; i < checkCount; i++, j--)
            {
                if (s[i] != s[j])
                {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }

        public static void fooBar()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i%15==0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (i%5==0)
                {
                    Console.WriteLine("Bar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizkidsDemo
{
    class Program
    {
        #region Main
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Task 1 : palindrome strings
            Console.WriteLine("Task1: Enter palindrome string : ");
            bool isPalindrome = palindrome(Console.ReadLine());
            Console.WriteLine(isPalindrome);
            Console.WriteLine("Press a button for task 2");
            Console.ReadKey();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Task2: FooBar");
            fooBar();
            Console.WriteLine("Press a button for task 3");
            Console.ReadKey();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Task3: Email Replacer");
            Console.WriteLine("Replacer : ");
            string replacer = Console.ReadLine();
            string text = emailReplacer("Christian has the email address christian+123@gmail.com.Christian's friend, John Cave-Brown, has the email address john.cave-brown@gmail.com.John's daughter Kira studies at Oxford University and has the email adress Kira123@oxford.co.uk.Her Twitter handle is @kira.cavebrown.",replacer);
            Console.WriteLine(text);
            Console.ReadKey();
            Console.WriteLine("----------------------------------");
        }
        #endregion
        #region Palindrome Strings
        /// <summary>
        /// Palindrome Strings Method
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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
        #endregion
        #region fooBar
        /// <summary>
        /// FooBar Method
        /// </summary>
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
        #endregion
        #region Email Replacer
        /// <summary>
        /// Email Replacer
        /// </summary>
        /// <param name="text"></param>
        /// <param name="replace"></param>
        /// <returns></returns>
        public static string emailReplacer(string text, string replace)
        {
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains("@"))
                {
                    string[] emailCandidate = words[i].Split('@');
                    if (emailCandidate.Length == 2)
                    {
                        if (emailCandidate[0].Length > 0)
                        {
                            if (emailCandidate[1].Contains(".co"))
                            {
                                text = text.Replace(words[i], replace);
                            }
                        }
                    }
                }
            }
            return text;
        }
        #endregion
    }
}

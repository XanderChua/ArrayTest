using System;
using System.Collections.Generic;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1)	Given an array of size N containing only 0s, 1s, and 2s; sort the array in ascending order.

            /*int[] a = { 20, 45, 1, 40, 98, 14, 29, 68};
            Console.WriteLine("--Welcome to sorting numbers--");         
            int temp = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - ( i + 1 ); j++)
                {
                    if(a[j] > a[j + 1])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }*/


            //2)	Given an unsorted array A of size N that contains only non-negative integers, find a continuous sub-array which adds to a given number S.

            /*int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("--Welcome to sum of numbers--");
            int S = 12;
            for (int i = 0; i < a.Length; i++)//outer loop which picks starting point i
            {
                int temp = 0;
                for (int j = i; j < a.Length; j++)//inner loop which tries everything from i
                {
                    temp = temp + a[j];
                    if (S == temp)
                    {
                        Console.WriteLine("Found array at index " + (i+1) + " to " + (j+1)); //i+1 cus array start with 0
                        return;
                    }
                    if (temp > S)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("No such sub array exist");*/


            //4)	Let the input string be “i like this program very much”. The function should change the string to “much very program this like i”

            /*private static void rev(char[] str, int first, int last)
            {

                char tempstore;
                while (first <= last) //swap
                {
                    tempstore = str[first];
                    str[first] = str[last];
                    str[last] = tempstore;
                    first++;
                    last--;
                }
            }

            static char[] reverse(char[] a) //reverse methodd
            {
                int first = 0;
                for (int last = 0; last < a.Length; last++)
                {
                    if (a[last] == ' ') //see space reverse
                    {
                        rev(a, first, last);
                        first = last + 1;
                    }
                }

                rev(a, first, a.Length - 1); //reverse last word
                rev(a, 0, a.Length - 1); //reverse everything
                return a;
            }
            public static void Main()
            {
                String s = "i love programming very much ";
                char[] b = reverse(s.ToCharArray());
                Console.Write(b);
            }*/


            //5)	Find whether a string is palindrome or not?

            /*Console.WriteLine("--Welcome to palindrome--");
            Console.WriteLine(" Input a string : ");
            string str;
            bool tf;
            str = Console.ReadLine();
            tf = IsPalindrome(str);
            if (tf == true)
            {
                Console.WriteLine(" The string is Palindrome.\n");
            }
            else
            {
                Console.WriteLine("The string is not a Palindrome.\n");
            }*/

            //Alternative method
            /*Console.WriteLine("--Welcome to palindrome--");
            Console.WriteLine(" Input a string : ");
            string input = Console.ReadLine();
            string reverse = string.Empty;
            int length = input.Length - 1;//reverse the input spelling

            while (length >= 0)//use reverse spelling to check letter by letter to match correct spelling
            {
                reverse = reverse + input[length];
                length--;//because it starts from the end, have to decrement by one each time it loops
            }
            if (input == reverse)
            {
                Console.WriteLine("The string is Palindrome.\n");
            }
            else
            {
                Console.WriteLine("The string is not a Palindrome.\n");
            }*/


            //6)	Given two numbers find the GCF (Greatest Common Factor) and LCM (Lowest Common Multiple) of the two numbers
            Console.WriteLine("--Welcome to GCF and LCM--");
            Console.WriteLine("1. Find greatest common factor ");
            Console.WriteLine("2. Find lowest common multiple ");
            int input = Int32.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: //GCF
                    {
                        Console.WriteLine("Enter 1st number:");
                        int a = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2nd number:");
                        int b = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("The greatest common factor of " + a + " and " + b + " is: " + gcf(a, b));
                        break;
                    }
                case 2: //LCM
                    {
                        Console.WriteLine("Enter 1st number:");
                        int a = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2nd number:");
                        int b = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("The lowest common multiple of " + a + " and " + b + " is: " + lcm(a, b));
                        break;
                    }
            }

        }

        //Q5 alternative method
        public static bool IsPalindrome(string text) 
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1]) //compare word spelt front to words spelt back 
                { 
                    return false; 
                }
                else
                {
                    return IsPalindrome(text.Substring(1, text.Length - 2));
                }

            }

            
        }

        //Q6 methods
        static int gcf(int a, int b)
        {
            if (a == 0)
                return b;
            return gcf(b % a, a);
        }
        static int lcm(int a, int b)
        {
            return (a / gcf(a, b)) * b;
        }
    }
}


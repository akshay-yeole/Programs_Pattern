using System;
using System.Collections.Generic;
using System.Text;

namespace Programs_Patterns
{
    public class NumberPatterns
    {

        public static void Pattern1(int userInput)
        {
            for (int i = 1; i <= userInput; i++)
            {
                for (int sp = userInput; sp > i; sp--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public static void Pattern2(int userInput)
        {
            for (int i = 1; i <= userInput; i++)
            {
                for (int j = 1; j <=i ; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Pattern3(int userInput)
        {
            for (int i = 1; i <= userInput; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public static void Pattern4(int userInput)
        {
            for (int i = userInput; i >= 1; i--)
            {
                for (int j = userInput; j >= i; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}

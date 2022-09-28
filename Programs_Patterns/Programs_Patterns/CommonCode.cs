using System;
using System.Collections.Generic;
using System.Text;

namespace Programs_Patterns
{
    public static class CommonCode
    {
        private static int userInput2;

        public static int readInput()
        {
            Console.Write("Enter Numer of Rows:: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int Menu()
        {
            Console.WriteLine("-------------------Numeric Programs----------------------");
            Console.WriteLine("01. Pattern 1\n     1\n    222\n   33333\nN.....");
            Console.WriteLine("\n02. Pattern 2\n1\n12\n123\nN.....");
            Console.WriteLine("\n03. Pattern 3\n1\n22\n333\nN.....");
            Console.WriteLine("\n04. Pattern 4\n3\n22\n111\nN.....");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter Choice :: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void performOperation(int userChoice)
        {
            int userInput;
            switch (userChoice)
            {
                case 1:
                    userInput = CommonCode.readInput();
                    NumberPatterns.Pattern1(userInput);
                    break;
                case 2:
                    userInput = CommonCode.readInput();
                    NumberPatterns.Pattern2(userInput);
                    break;
                case 3:
                    userInput = CommonCode.readInput();
                    NumberPatterns.Pattern3(userInput);
                    break;
                case 4:
                    userInput = CommonCode.readInput();
                    NumberPatterns.Pattern4(userInput);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        public static void TheEnd()
        {
            Console.WriteLine("!!! Press Any Key To Exit !!!");
            Console.ReadLine();
        }

        public static string isContinue()
        {
            Console.WriteLine("\nDo you want to continue ? (Y|N)");
            return Console.ReadLine().ToUpper();
        }
    }
}

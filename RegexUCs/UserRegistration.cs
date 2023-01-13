using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUCs
{
    public class UserRegistration
    {
        public static void FirstName()      //UC1
        {
            Console.WriteLine("Enter your FirstName");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$";
            Iteration(userInput, regexCondition);
        }
        public static void LastName()      //UC2
        {
            Console.WriteLine("Enter your LastName");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$";
            Iteration(userInput, regexCondition);
        }
        public static void EmailValidating()      //UC3
        {
            Console.WriteLine("Enter your Email Address");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-z]{1}[a-z]{2}(.)[a-z]{3}(@bl.co)$";
            Iteration(userInput, regexCondition);
        }
        public static void MobileNumber()      //UC4
        {
            Console.WriteLine("Enter your MobileNumber");
            string userInput = Console.ReadLine();
            string regexCondition = "^[0-9]{2}[ ][0-9]{10}$";
            Iteration(userInput, regexCondition);
        }
        public static void PassMin8Char()      //UC5
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-zA-Z0-9]{8,}$";
            Iteration(userInput, regexCondition);
        }
        public static void PassMin8CharAnd1UpperCase() //UC6 (min 8 char and atleast 1 upper case in it.
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^(?=.*[A-Z]).{1,}[a-zA-Z0-9]{7,}$";
            Iteration(userInput, regexCondition);
        }
        public static void UpperCase1AndNumeric1() //UC7 (min 8 char and atleast 1 upper case and 1 numeric in it.
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^(?=.*[A-Z]).{1,}(?=.*[0-9]).{1,}[a-zA-Z0-9]{6,}$";
            Iteration(userInput, regexCondition);
        }
        public static void Iteration(string userInput, string regexCondition)
        {
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
            }
        }
    }
}

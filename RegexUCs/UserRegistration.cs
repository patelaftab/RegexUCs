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
        public static void SpecialCharacter1() //UC8 (all condition same as previous+ 1 exact special Char.)
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";
            Iteration(userInput, regexCondition);
        }
        public static void EmailSample()        //UC9  Email Samples Validation .
        {
            string[] userInput = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au",
                                "abc@1.com","abc@gmail.com.com","abc+100@gmail.com",
                                "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com",
                                "abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            foreach (string input in userInput)
            {
                if (Regex.IsMatch(input, regexCondition))
                {
                    Console.WriteLine($"{input} --> Valid");
                }
                else
                {
                    Console.WriteLine($"{input} --> Invalid");
                }
            }
        }
        public static void Iteration(string userInput, string regexCondition)
        {
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Registered Successfully!\n");
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
            }
        }
    }
}

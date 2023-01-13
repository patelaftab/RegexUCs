namespace RegexUCs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Program\n");
            Console.WriteLine("Choose a Valid Option From Below\n" +
                "1]: For User Name validation\n" +
                "2]: For User Last Name validation\n" +
                "3]: For User Email validation\n" +
                "4]: For User Mbile Number validation\n" +
                "5]: For User Password validation\n" +
                "6]: For User Password of Minimun 1 character in upper Case");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option) 
            {
                case 1:
                    UserRegistration.FirstName();
                    break;
                case 2:
                        UserRegistration.LastName();
                    break;
                case 3:
                        UserRegistration.EmailValidating();
                    break;
                case 4:
                    UserRegistration.MobileNumber();
                    break;
                case 5:
                    UserRegistration.PassMin8Char();
                    break;
                case 6:
                    UserRegistration.PassMin8CharAnd1UpperCase();
                    break;
                default:
                    Console.WriteLine("Choose a Valid Option");
                    break;
            }
          
        }
    }
}
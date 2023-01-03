namespace RegexUCs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Program\n");
            Console.WriteLine("Choose a VAlid Option From Below\n" +
                "1]: For User Name validation");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option) 
            {
                case 1:
                    UserRegistration.FirstName();
                    break;
                default:
                    Console.WriteLine("Choose a Valid Option");
                    break;
            }
          
        }
    }
}
using System;

namespace MenuShellErnst.View
{
    class AdminAddView : View
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public override string Display()
        {
            string result;

            do
            {
                base.Display();

                Console.WriteLine("Create a new user account:");

                Console.Write("\nUsername: ");
                UserName = Console.ReadLine();
                Console.Write("\nPassword: ");
                Password = Console.ReadLine();
                Console.Write("\nRole: ");
                Role = Console.ReadLine();
                Console.WriteLine("Is this correct (Y)es/(N)o?");
                result = Console.ReadLine();

            } while (result.ToUpper() != "Y");
            return result;
        }

    }
}

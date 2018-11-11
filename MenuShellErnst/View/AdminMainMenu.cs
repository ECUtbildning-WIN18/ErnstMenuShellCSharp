using System;

namespace MenuShellErnst.View
{
    class AdminMainMenu : View
    {
        public override string Display()
        {
            base.Display();
    
            Console.WriteLine("1. Manage users");
            Console.WriteLine("2. Log out");
            Console.WriteLine("3. Exit");
            string result = Console.ReadLine();
            return result;
        }
    }
}

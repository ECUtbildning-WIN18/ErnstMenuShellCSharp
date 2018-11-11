using System;

namespace MenuShellErnst.View
{
    class ManageUserView : View
    {
        public override string Display()
        {
            base.Display();
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Delete user");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}

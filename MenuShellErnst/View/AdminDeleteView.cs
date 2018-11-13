using System;
using System.Threading;

namespace MenuShellErnst.View
{
    class AdminDeleteView : View        
    {
        public override string Display()
        {
            base.Display();
            Console.WriteLine("Who are you looking for?");
            return "";
        }
    }
}

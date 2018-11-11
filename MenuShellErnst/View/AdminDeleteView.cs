using System;
using System.Threading;

namespace MenuShellErnst.View
{
    class AdminDeleteView : View        
    {
        public override string Display()
        {
            base.Display();
            Console.WriteLine("Choose user to delete?");
            Thread.Sleep(1000);
            return "";
        }
    }
}

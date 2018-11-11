using MenuShellErnst.Domain;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MenuShellErnst.View
{
    class DeleteUser
    {
        public void RemoveUser(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($" ({ i + 1}) {users[i].UserName}");
            }

            Console.WriteLine("Choose user to remove.");
            int removal = int.Parse(Console.ReadLine());
            Thread.Sleep(500);
            users.RemoveAt(removal - 1);

        }
    }
}

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
            users.RemoveAt(removal - 1);

        }

        public void RemoveUserSearch(List<User> users, List<User> foundUsers)
        {
            /*for (int i = 0; i < foundUsers.Count; i++)
            {
                Console.WriteLine($" ({ i + 1}) {users[i].UserName}");
            }*/
            int counter = -1;
            Console.WriteLine("Choose user to remove. Enter name.");
            string removeThisUser = Console.ReadLine();
            foreach (var item in users)
            {
                counter++;
                if (item.UserName == removeThisUser)
                {
            //        users.Remove(item);
                    break;
                }
            }
            users.RemoveAt(counter);
        }

        public void searchRemoveUser(string s, List<User> users)
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

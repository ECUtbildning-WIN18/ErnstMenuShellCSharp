
using MenuShellErnst.Domain;
using MenuShellErnst.View;
using System;
using System.Collections.Generic;
using MenuShellErnst.Services;
using System.Threading;

namespace MenuShellErnst
{
    class Program 
    {
        static void Main(string[] args)
        {
            var users = new List<User>();
            {
                users.Add(new User(userName: "Admin", passWord: "secret", role: "Administrator"));
                users.Add(new User(userName: "Reception", passWord: "secret", role: "Receptionist"));
            }

            var loginView = new LoginView();
            var receptionistMainView = new ReceptionistMainView();
            var adminMainMenu = new AdminMainMenu();
            var adminAddUser = new AdminAddView();
            var adminDeleteUser = new AdminDeleteView();
            var manageUser = new ManageUserView();
            var registerUser = new RegisterUser();
            var printUser = new PrintUser(); 
            var authentication = new AuthenticationServices();
            var deleteUser = new DeleteUser();
            string result;
            User onlineUser = null;
            
            do
            {
                result = loginView.Display();
                if (result.ToUpper() == "Y")
                {
                    Console.Clear();
                    onlineUser = authentication.Authenticate(loginView.Username, loginView.Password, users);

                    if (onlineUser == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Login failed, try again!");
                        Thread.Sleep(1000);
                    }
                }
            }
            while (onlineUser == null);

            do
            {
                if (onlineUser.Role == "Receptionist")
                {
                    result = receptionistMainView.Display();  
                    switch (result)
                    {
                        case "D1":
                            result = printUser.Display();                           
                             printUser.ListAllUsers(users);       
                            break;

                        case "D2":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Wrong input, try again!");
                            Thread.Sleep(2000);
                            break;            
                    }
                }
                else if (onlineUser.Role == "Administrator")
                {
                    result = adminMainMenu.Display();
                    switch (result)
                    {
                        case "1":
                            result = manageUser.Display();
                            if (result == "1")
                            {
                                adminAddUser.Display();
                                registerUser.AddNewUser(adminAddUser.UserName, adminAddUser.Password, adminAddUser.Role, users);
                            }
                            else if (result == "2")
                            {
                                adminDeleteUser.Display();
                                deleteUser.RemoveUser(users);
                            }
                            break;

                        case "2":
                            loginView.Display();
                            break;

                        case "3":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Wrong input");
                            Thread.Sleep(2000);
                            break;
                    }
                }
            } while (onlineUser != null);

        }
    }
}

using MenuShellErnst.Domain;
using System.Collections.Generic;

namespace MenuShellErnst.Services
{
    class AuthenticationServices : IAuthenticationServices
    {
        public User Authenticate(string username, string password, List<User> users)
        {
            User _user = null;

            foreach (User user in users)
            {
                if (user.UserName == username && user.PassWord == password)
                {
                    _user = user;
                    break;
                }
            }
            return _user;
        }
    }
}

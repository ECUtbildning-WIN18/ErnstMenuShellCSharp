using MenuShellErnst.Domain;
using System.Collections.Generic;

namespace MenuShellErnst.Services
{
    interface IAuthenticationServices
    {
            User Authenticate(string userName, string passWord, List<User> _users);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShellErnst.Domain;

namespace MenuShellErnst.Services
{
    class SearchUser
    {
        public List<User> searchUser( string s, List<User> ul )
        {
            List<User> searchResult = new List<User>();
            foreach (var item in ul)
            {
                if (item.UserName.StartsWith(s))
                {
                    searchResult.Add(item);
                }
            }
            return searchResult;
        }
    }
}

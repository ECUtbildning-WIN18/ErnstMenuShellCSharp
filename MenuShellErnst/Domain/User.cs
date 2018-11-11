namespace MenuShellErnst.Domain
{
    class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Role { get; set; }

        public User(string userName, string passWord, string role)
        {
            UserName = userName;
            PassWord = passWord;
            Role = role;
        }
    }
}

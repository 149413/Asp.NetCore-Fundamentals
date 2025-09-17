namespace Assiagn03.Q_02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        List<Credentials_DB> credentials = new List<Credentials_DB>()
        {
            new Credentials_DB() { UseName = "Ahmed Ali" , Password = "abc123" , Role = Role.Admin},
            new Credentials_DB() { UseName = "Omar Samy" , Password = "xyz123" , Role = Role.Moderator},
            new Credentials_DB() { UseName = "Mariam Ahmed" , Password = "abc456" , Role = Role.Member},
            new Credentials_DB() { UseName = "Ola Mohamed" , Password = "olm123" , Role = Role.User},
            new Credentials_DB() { UseName = "Amr Seliam" , Password = "xyz456" , Role = Role.Gust},
            new Credentials_DB() { UseName = "Ali Omar" , Password = "alm123" , Role = Role.None},

        };
        public string Name { get; set; }
        public string password { get; set; }

        public BasicAuthenticationService(string name, string password)
        {
            Name = name;
            this.password = password;
        }

        public bool AuthenticateUser()
        {
            foreach (var item in credentials)
            {
                if (Name.ToLower() == item.UseName.ToLower())
                {
                    if (password == item.Password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AuthorizeUser()
        {
            foreach (var item in credentials)
            {
                if (Name.ToLower() == item.UseName.ToLower() &&
                    password == item.Password)
                {
                    if (item.Role == Role.Admin || item.Role == Role.Moderator || item.Role == Role.Member || item.Role == Role.Gust)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }
}

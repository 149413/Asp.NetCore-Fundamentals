namespace Assiagn03.Q_02
{
    enum Role
    {
        None,
        Admin,
        Moderator,
        User = 3,
        Member = 3,
        Gust
    }
    [Flags]
    enum Permission : byte
    {
        None = 0,
        Inset = 1,
        update = 2,
        Delete = 4,
        React = 8,
        Comment = 16,
        Share = 32,
        View_Content = 64,
        All_Permission = 127
    }

    internal class Credentials_DB
    {
        public string UseName { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }
        public Permission Permission { get; set; }


        public void GivePermission()
        {
            switch (Role)
            {
                case Role.Admin:
                    Permission = Permission.Inset | Permission.update | Permission.Delete;
                    break;
                case Role.Moderator:
                    Permission = Permission.Inset | Permission.React | Permission.Comment | Permission.Share | Permission.View_Content;
                    break;
                case Role.Member:
                    Permission = Permission.React | Permission.Comment | Permission.Share | Permission.View_Content;
                    break;
                case Role.Gust:
                    Permission = Permission.View_Content;
                    break;
                default:
                    Permission = Permission.None;
                    break;
            }
        }


    }
}

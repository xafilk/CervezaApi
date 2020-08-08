using System.Collections.Generic;
using Cerveza.Common.Entities;

namespace Cerveza.DataAccessLogic.DB
{
    public static class UsersTable
    {
        #region Properties 
        public static List<User> UsersInfo { get; set; }
        #endregion Properties

        public static void InitUsersTable()
        {
            UsersInfo = new List<User>
            {
                new User() { UserName = "TestUser1", Password = "Q2VydmV6YUFwaQ==" }, //CervezaApi
                new User() { UserName = "Admin1", Password = "NGRtMW4xc3RyNGQwcg====" } //4dm1n1str4d0r
            };
        }
    }
}

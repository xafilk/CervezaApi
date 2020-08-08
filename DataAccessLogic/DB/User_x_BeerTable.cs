using Cerveza.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerveza.DataAccessLogic.DB
{
    public static class User_x_BeerTable
    {
        public static List<User_x_Beer> User_x_BeerInfo { get; set; }

        public static void InitUser_x_BeerTable()
        {
            User_x_BeerInfo = new List<User_x_Beer>()
            {
                new User_x_Beer(0){ UserName = "TestUser1", BeerId = 1, TotalConsumption = 0 },
                new User_x_Beer(1){ UserName = "TestUser1", BeerId = 2, TotalConsumption = 5 },
                new User_x_Beer(2){ UserName = "TestUser1", BeerId = 3, TotalConsumption = 0 }
            };  
        }
    }
}

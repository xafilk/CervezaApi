using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cerveza.Common.Entities;
using Cerveza.DataAccessLogic.DB;

namespace Cerveza.DataAccessLogic.DBAccess
{
    public class DBDataReader
    {
        /// <summary>
        /// Get all users on the DataBase
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            return UsersTable.UsersInfo;
        }

        /// <summary>
        /// Get an User by UserName
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public User GetUserById(string userName)
        {
            return UsersTable.UsersInfo.Find((x) => x.UserName == userName);
        }

        /// <summary>
        /// Get all Beers on DataBase
        /// </summary>
        /// <returns></returns>
        public List<Beer> GetAllBeer()
        {
            return BeersTable.BeersInfo;
        }

        /// <summary>
        /// Get a Beer by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Beer GetBeerById(int id)
        {
            return BeersTable.BeersInfo.Find((x) => x.Id == id);
        }

        /// <summary>
        /// Get Consumption Info
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="beerId"></param>
        /// <returns></returns>
        public User_x_Beer GetConsumptionById(string userName, int beerId)
        {
            return User_x_BeerTable.User_x_BeerInfo.Find((x) => (x.UserName == userName) && (x.BeerId == beerId));
        }

        /// <summary>
        /// Add consumption amount to the data set
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="beerId"></param>
        /// <param name="value">Amount of mililiters</param>
        /// <returns></returns>
        public bool AddComsumptionAmount(string userName, int beerId, int value)
        {
            bool response = false;
            try
            {
                User_x_BeerTable.User_x_BeerInfo.Find((x) => (x.UserName == userName) && (x.BeerId == beerId)).TotalConsumption += value;
                response = true;
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }
    }
}

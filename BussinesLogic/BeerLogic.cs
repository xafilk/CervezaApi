using Cerveza.Common.Entities;
using Cerveza.DataAccessLogic.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerveza.BussinesLogic
{
    public class BeerLogic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Response<List<Beer>> GetAllBeerInfo()
        {
            Response<List<Beer>> response = new Response<List<Beer>>();
            DBDataReader dbReader = new DBDataReader();
            try
            {
                List<Beer> beerList = dbReader.GetAllBeer();
                if (beerList != null)
                {
                    response.StatusCode = 200;
                    response.Success = true;
                    response.Message = string.Empty;
                    response.Object = beerList;
                }
                else
                {
                    response.Message = "Error during the execution";
                    response.Success = false;
                    response.StatusCode = 29;
                }
            }
            catch (Exception)
            {
                //Log the Exception into SQL or Elastic Search or disk(Log4Net or Serilog)
                response.Message = "Error during the execution";
                response.Success = false;
                response.StatusCode = 29;
            }
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Response<Beer> GetBeerById(int id)
        {
            Response<Beer> response = new Response<Beer>();
            DBDataReader dbReader = new DBDataReader();
            try
            {
                Beer beer = dbReader.GetBeerById(id);
                if (beer != null)
                {
                    response.StatusCode = 200;
                    response.Success = true;
                    response.Message = string.Empty;
                    response.Object = beer;
                }
                else
                {
                    response.Message = "Error during the execution";
                    response.Success = false;
                    response.StatusCode = 29;
                }
            }
            catch (Exception)
            {
                //Log the Exception into SQL or Elastic Search or disk(Log4Net or Serilog)
                response.Message = "Error during the execution";
                response.Success = false;
                response.StatusCode = 29;
            }
            return response;
        }

        /// <summary>
        /// Get User Beer Comsuption Information
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="beerId"></param>
        /// <returns></returns>
        public Response<ConsumptionInfo> GetConsumption(string userName, int beerId)
        {
            Response<ConsumptionInfo> response = new Response<ConsumptionInfo>();
            DBDataReader jsonDataReader = new DBDataReader();
            try
            {
                User_x_Beer consumption = jsonDataReader.GetConsumptionById(userName, beerId);
                if (consumption != null)
                {
                    Beer beer = jsonDataReader.GetBeerById(beerId);
                    ConsumptionInfo info = new ConsumptionInfo()
                    {
                        UserName = userName,
                        BeerAlcoholPercentage = beer.AlcoholPercentage,
                        BeerBrand = beer.Brand,
                        BeerType = beer.Type,
                        ConsumptionVolum = consumption.TotalConsumption
                    };
                    response.Object = info;
                    response.StatusCode = 200;
                    response.Success = true;
                }
                else
                {
                    response.Message = "Invalid UserName or Beer Id, Or Not exist information for this user-beer realtion";
                    response.StatusCode = 202;
                    response.Success = false;
                }
            }
            catch (Exception)
            {
                //Log the Exception into SQL or Elastic Search or disk(Log4Net or Serilog)
                response.Message = "Error during the execution";
                response.Success = false;
                response.StatusCode = 29;
            }
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Response<int> AddConsumption(string userName, int id, int value)
        {
            Response<int> response = new Response<int>();
            DBDataReader dbReader = new DBDataReader();
            try
            {
                bool update = dbReader.AddComsumptionAmount(userName, id, value);
                if (update)
                {
                    response.Success = true;
                    response.StatusCode = 200;
                    response.Message = "Add Succesfully";
                }
                else
                {
                    response.Success = false;
                    response.StatusCode = 203;
                    response.Message = "Error, The relation User x BeerId doesn't exist, please review the Id's or Add a new Relation";
                }
            }
            catch (Exception)
            {
                //Log the Exception into SQL or Elastic Search or disk(Log4Net or Serilog)
                response.Message = "Error during the execution";
                response.Success = false;
                response.StatusCode = 29;
            }
            return response;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cerveza.BussinesLogic;
using Cerveza.Common.Entities;
using Newtonsoft.Json;

namespace CervezaWebApi.Controllers
{
    public class BeerController : ApiController
    {
        /// <summary>
        /// Get
        /// api/Beer/GetAll
        /// </summary>
        /// <returns></returns>
        [Route("api/beer/GetAll")]
        [HttpGet]
        public Response<List<Beer>> GetAll()
        {
            Response<List<Beer>> response;
            try
            {
                BeerLogic logic = new BeerLogic();
                response = logic.GetAllBeerInfo();
            }
            catch (Exception)
            {
                //Log the Exception into SQL or Elastic Search or disk(Log4Net or Serilog)
                response = new Response<List<Beer>>
                {
                    Message = "Error during the execution",
                    Success = false,
                    StatusCode = 29
                };
            }
            return response;
        }

        /// <summary>
        /// Get
        /// api/Beer/GetById?id=<int>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/beer/GetById")]
        [HttpGet]
        public Response<Beer> GetById(int id)
        {
            Response<Beer> response;
            try
            {
                BeerLogic logic = new BeerLogic();
                response = logic.GetBeerById(id);
            }
            catch (Exception)
            {
                //Log the Exception into SQL or Elastic Search or disk(Log4Net or Serilog)
                response = new Response<Beer>
                {
                    Message = "Error during the execution",
                    Success = false,
                    StatusCode = 29
                };
            }
            return response;
        }

        /// <summary>
        /// Post
        /// api/User/GetConsumptionInfo
        /// </summary>
        /// <param name="beerId"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        [Route("api/beer/GetConsumptionInfo")]
        [HttpPost]
        public Response<ConsumptionInfo> GetConsumptionInfo(int beerId, [FromBody]User userName)
        {
            Response<ConsumptionInfo> response;
            try
            {
                BeerLogic beerLogic = new BeerLogic();
                response = beerLogic.GetConsumption(userName.UserName, beerId);
            }
            catch (Exception)
            {
                //Log the Exception into SQL or Elastic Search or disk(Log4Net or Serilog)
                response = new Response<ConsumptionInfo>
                {
                    Message = "Error during the execution",
                    Success = false,
                    StatusCode = 29
                };
            }
            return response;
        }

        /// <summary>
        /// Post
        /// api/User/AddConsumption
        /// </summary>
        /// <param name="beerId"></param>
        /// <param name="value"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        [Route("api/beer/AddConsumption")]
        [HttpPost]
        public Response<int> AddConsumption(int beerId, int value, [FromBody]User userName)
        {
            Response<int> response;
            try
            {
                BeerLogic beerLogic = new BeerLogic();
                response = beerLogic.AddConsumption(userName.UserName, beerId, value);
            }
            catch (Exception)
            {
                //Log the Exception into SQL or Elastic Search or disk(Log4Net or Serilog)
                response = new Response<int>
                {
                    Message = "Error during the execution",
                    Success = false,
                    StatusCode = 29
                };
            }
            return response;
        }

    }
}
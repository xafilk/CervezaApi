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
    public class UserController : ApiController
    {
        /// <summary>
        /// Post
        /// api/User/ValidateUser
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("api/User/ValidateUser")]
        [HttpPost]
        public Response<int> ValidateUser([FromBody]User value)
        {
            Response<int> response;
            try
            {
                UserLogic userLogic = new UserLogic();
                response = userLogic.ValidateUser(value);
            }
            catch(Exception)
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

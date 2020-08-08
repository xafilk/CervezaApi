using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cerveza.Common;
using Cerveza.Common.Entities;
using Cerveza.DataAccessLogic.DBAccess;

namespace Cerveza.BussinesLogic
{
    public class UserLogic
    {
        public Response<int> ValidateUser(User user)
        {
            Response<int> response = new Response<int>();
            DBDataReader jsonDataReader = new DBDataReader();

            try
            {
                User myUser = jsonDataReader.GetUserById(user.UserName);
                bool isUser;
                if (myUser != null)
                {
                    isUser = (EncryptHelper.DecodeBase64StringToString(myUser.Password) == EncryptHelper.DecodeBase64StringToString(user.Password));
                    response.Success = isUser;
                    if (isUser)
                    {
                        response.Message = "Valid User";
                        response.StatusCode = 200;
                    }
                    else
                    {
                        response.Message = "Invalid Password";
                        response.StatusCode = 201;
                    }
                }
                else
                {
                    response.Message = "Invalid User";
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
    }
}

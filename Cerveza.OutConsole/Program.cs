using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cerveza.DataAccessLogic.JsonAccess;

namespace Cerveza.OutConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonDataReader json = new JsonDataReader();
            json.GetUsers();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerveza.Common.Entities
{
    public class User_x_Beer
    {
        public int Id { get; }
        public string UserName { get; set; }

        public int BeerId { get; set; }

        /// <summary>
        /// Represent the total consuption for an user of and specific Beer.
        /// Value in MiliLiters
        /// </summary>
        public int TotalConsumption { get; set; }

        public User_x_Beer(int id)
        {
            Id = id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerveza.Common.Entities
{
    public class Beer
    {
        public int Id { get; }
        /// <summary>
        /// Beer Brand
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Percentage of alcohol present on the beer
        /// </summary>
        public int AlcoholPercentage { get; set; }

        /// <summary>
        /// Type of beer
        /// </summary>
        public string Type { get; set; }

        public Beer(int id)
        {
            Id = id;
        }
    }
}

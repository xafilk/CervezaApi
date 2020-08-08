using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerveza.Common.Entities
{
    public class ConsumptionInfo
    {
        public string UserName { get; set; }
        public string BeerBrand { get; set; }
        public string BeerType { get; set; }
        public int BeerAlcoholPercentage { get; set; }
        public int ConsumptionVolum { get; set; }

    }
}

using System.Collections.Generic;
using Cerveza.Common.Entities;

namespace Cerveza.DataAccessLogic.DB
{
    public static class BeersTable
    {
        #region Propeties
        public static List<Beer> BeersInfo{get; set;}
        #endregion

        public static void InitBeersTable()
        {
            BeersInfo = new List<Beer>
            {
                new Beer(1) { AlcoholPercentage = 6, Brand = "Imperial", Type = "Lagers" },
                new Beer(2) { AlcoholPercentage = 4, Brand = "Pilsen", Type = "Pilsen" },
                new Beer(3) { AlcoholPercentage = 5, Brand = "Heineken", Type = "‎Pale lager" },
                new Beer(4) { AlcoholPercentage = 3, Brand = "Duff", Type = "Lagers" }
            };
        }
    }
}

using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class PriceBusinessLogic
    {
        PriceDataAccess priceDataAccess;
        public PriceBusinessLogic()
        {
            priceDataAccess = new PriceDataAccess();
        }

        //添加价格
        public bool AddPrice(Price price)
        {
            return priceDataAccess.AddPrice(price);

        }
    }
}

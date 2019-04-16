using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class PriceDataAccess
    {
        PriceDataContext priceDataContext;

        //构造方法
        public PriceDataAccess()
        {
            this.priceDataContext = new PriceDataContext();
        }
        
        public bool AddPrice(Price price)
        {
            try
            {
                this.priceDataContext.Price.InsertOnSubmit(price);
                this.priceDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

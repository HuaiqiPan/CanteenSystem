using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class View_PriceBusinessLogic
    {
        View_PriceDataAccess view_PriceDataAccess = new View_PriceDataAccess();
        //返回所有菜品价格
        public List<View_Price> GetAllPrice()
        {
            return this.view_PriceDataAccess.GetAllPrice();
        }
        //根据菜品名称返回菜品价格
        public List<View_Price> GetPriceByName(string menuName)
        {
            return this.view_PriceDataAccess.GetPriceByName(menuName);
        }
        //根据菜品名称、开始时间、结束时间查找菜品价格
        public List<View_Price> GetPriceByName(string munename, string startDate, string endDate)
        {
            return this.view_PriceDataAccess.GetPriceByName(munename, startDate, endDate);
        }
        //根据菜品名称、开始时间查找菜品价格
        public List<View_Price> GetPriceByStartDate(string munename, string startDate)
        {
            return this.view_PriceDataAccess.GetPriceByStartDate(munename, startDate);
        }
        //根据菜品名称、结束时间查找菜品价格
        public List<View_Price> GetPriceByEndDate(string munename, string endDate)
        {
            return this.view_PriceDataAccess.GetPriceByEndDate(munename, endDate);
        }
        public List<View_Price> GetAllPriceByDate(string startDate, string endDate)
        {
            return this.view_PriceDataAccess.GetAllPriceByDate(startDate, endDate);
        }
        public List<View_Price> GetAllPriceByStartDate(string startDate)
        {
            return this.view_PriceDataAccess.GetAllPriceByStartDate(startDate);
        }
        public List<View_Price> GetAllPriceByEndDate(string endDate)
        {
            return this.view_PriceDataAccess.GetAllPriceByEndDate(endDate);
        }
    }
}

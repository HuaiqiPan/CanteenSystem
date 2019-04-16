using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class View_PriceDataAccess
    {
        View_PriceDataContext view_PriceDataContext = new View_PriceDataContext();
        //返回所有菜品价格
        public List<View_Price> GetAllPrice()
        {
            return this.view_PriceDataContext.View_Price.OrderBy(o => o.MenuName).OrderByDescending(o=>o.InputDate).ToList();
        }
        //根据菜品名称返回菜品价格
        public List<View_Price> GetPriceByName(string menuName)
        {
            return this.view_PriceDataContext.View_Price.Where(o => o.MenuName == menuName).OrderByDescending(o => o.InputDate).ToList();
        }

        //根据菜品名称、开始时间、结束时间查找菜品价格
        public List<View_Price> GetPriceByName(string munename, string startDate, string endDate)
        {
            List<View_Price> priceList = new List<View_Price>();
            priceList = this.view_PriceDataContext.View_Price.Where(o => o.MenuName==munename &&
                    (o.InputDate >= DateTime.Parse(startDate) && o.InputDate <= DateTime.Parse(endDate))).OrderByDescending(o => o.InputDate).ToList();
            return priceList;
        }
        //根据菜品名称、开始时间查找菜品价格
        public List<View_Price> GetPriceByStartDate(string munename, string startDate)
        {
            List<View_Price> mroList = new List<View_Price>();
            mroList = this.view_PriceDataContext.View_Price.Where(o => o.MenuName == munename &&
                    (o.InputDate >= DateTime.Parse(startDate))).OrderByDescending(o => o.InputDate).ToList();
            return mroList;
        }
        //根据菜品名称、结束时间查找菜品价格
        public List<View_Price> GetPriceByEndDate(string munename, string endDate)
        {
            List<View_Price> mroList = new List<View_Price>();
            mroList = this.view_PriceDataContext.View_Price.Where(o => o.MenuName == munename &&
                    (o.InputDate <= DateTime.Parse(endDate))).OrderByDescending(o => o.InputDate).ToList();
            return mroList;
        }
        public List<View_Price> GetAllPriceByDate(string startDate, string endDate)
        {
            List<View_Price> priceList = new List<View_Price>();
            priceList = this.view_PriceDataContext.View_Price.Where((o=>o.InputDate >= DateTime.Parse(startDate) &&
            o.InputDate <= DateTime.Parse(endDate))).OrderBy(o => o.MenuName).OrderByDescending(o => o.InputDate).ToList();
            return priceList;
        }
        public List<View_Price> GetAllPriceByStartDate(string startDate)
        {
            List<View_Price> priceList = new List<View_Price>();
            priceList = this.view_PriceDataContext.View_Price.Where((o => o.InputDate >= DateTime.Parse(startDate))).OrderBy(o => o.MenuName).OrderByDescending(o => o.InputDate).ToList();
            return priceList;
        }
        public List<View_Price> GetAllPriceByEndDate(string endDate)
        {
            List<View_Price> priceList = new List<View_Price>();
            priceList = this.view_PriceDataContext.View_Price.Where((o => o.InputDate <= DateTime.Parse(endDate))).OrderBy(o => o.MenuName).OrderByDescending(o => o.InputDate).ToList();
            return priceList;
        }
    }
}

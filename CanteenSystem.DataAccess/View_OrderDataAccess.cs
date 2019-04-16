using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class View_OrderDataAccess
    {
        View_OrderDataContext view_OrderDataContext;
        public View_OrderDataAccess()
        {
            this.view_OrderDataContext = new View_OrderDataContext();
        }

        public List<View_Order> GetAllView_Order()
        {
            return this.view_OrderDataContext.View_Order.ToList();
        }
        public List<View_Order> GetView_OrderByStatus(string Status)
        {
            List<View_Order> view_OrderList = new List<View_Order>();
            view_OrderList = this.view_OrderDataContext.View_Order.Where(o => o.Status.Contains(Status)).OrderBy(o => o.Group).OrderBy(o => o.ProviderName).ToList();
            return view_OrderList;
        }
        public bool UpdataView_Order(View_Order view_Order)
        {
            try
            {
                view_OrderDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

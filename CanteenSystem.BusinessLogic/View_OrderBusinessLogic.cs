using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class View_OrderBusinessLogic
    {
        View_OrderDataAccess view_OrderDateAccess;
        public View_OrderBusinessLogic()
        {
            view_OrderDateAccess = new View_OrderDataAccess();
        }

        public List<View_Order> GetAllView_Order()
        {
            return this.view_OrderDateAccess.GetAllView_Order();
        }
        public List<View_Order> GetView_OrderByStatus(string Status)
        {

            return this.view_OrderDateAccess.GetView_OrderByStatus(Status);
        }
        public bool UpdataView_Order(View_Order view_Order)
        {
            return this.view_OrderDateAccess.UpdataView_Order(view_Order);
        }
    }
}

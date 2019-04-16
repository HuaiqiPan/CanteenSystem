using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class View_MenuDataAccess
    {
        View_MenuDataContext view_MenuDataContext;
        public View_MenuDataAccess()
        {
            this.view_MenuDataContext = new View_MenuDataContext();
        }

        public List<View_Menu> GetAllView_Menu()
        {
            return this.view_MenuDataContext.View_Menu.ToList();
        }
        public List<View_Menu> GetView_MenuByOrderID(string orderID)
        {
            List<View_Menu> view_MenuList = new List<View_Menu>();
            view_MenuList = this.view_MenuDataContext.View_Menu.Where(o => o.OrderID.Contains(orderID)).OrderBy(o=>o.ProviderName).ToList();
            return view_MenuList;
        }
        public bool UpdataView_Menu(View_Menu view_Menu)
        {
            try
            {
                view_MenuDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

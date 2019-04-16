using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class View_MenuBusinessLogic
    {
        View_MenuDataAccess view_MenuDateAccess;
        public View_MenuBusinessLogic()
        {
            view_MenuDateAccess = new View_MenuDataAccess();
        }

        public List<View_Menu> GetAllView_Menu()
        {
            return this.view_MenuDateAccess.GetAllView_Menu();
        }
        public List<View_Menu> GetView_MenuByOrderID(string orderID)
        {

            return this.view_MenuDateAccess.GetView_MenuByOrderID(orderID);
        }
        public bool UpdataView_Menu(View_Menu view_Menu)
        {
            return this.view_MenuDateAccess.UpdataView_Menu(view_Menu);
        }
    }
}

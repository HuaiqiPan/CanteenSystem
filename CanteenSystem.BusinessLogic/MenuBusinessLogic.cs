using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenSystem.DataAccess;
using CanteenSystem.Model;

namespace CanteenSystem.BusinessLogic
{
    public class MenuBusinessLogic
    {
        MenuDataAccess menuDataAccess;
        public MenuBusinessLogic()
        {
            menuDataAccess = new MenuDataAccess();
        }
        public bool AddMenu(Menu menu)
        {
            return menuDataAccess.AddMenu(menu);

        }

        public List<Menu> GetAllMenu()
        {
            return menuDataAccess.GetAllMenu();
        }

        public Menu GetMenuByID(string menuID)
        {
            return menuDataAccess.GetMenuByID(menuID);
        }
        public Menu GetMenuByName(string menuName)
        {
            return menuDataAccess.GetMenuByName(menuName);
        }
        public List<string> GetMenusByMenuName(string menuName)
        {
            return this.menuDataAccess.GetMenusByMenuName(menuName);
        }
        public bool DeleteMenuByMenuID(string menuID)
        {
            return menuDataAccess.DeleteMenuByMenuID(menuID);
        }
        public bool UpdataMenu(Menu menu)
        {
            return menuDataAccess.UpdataMenu(menu);
        }
    }
}

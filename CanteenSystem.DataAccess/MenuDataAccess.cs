using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class MenuDataAccess
    {
        MenuDataContext menuDataContext;

        //构造方法
        public MenuDataAccess()
        {
            this.menuDataContext = new MenuDataContext();
        }

        public bool AddMenu(Menu menu)
        {
            try
            {
                this.menuDataContext.Menu.InsertOnSubmit(menu);
                this.menuDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        //查询所有菜单
        public List<Menu> GetAllMenu()
        {
            return this.menuDataContext.Menu.ToList();
        }

        public Menu GetMenuByID(string menuID)
        {
            Menu menu = new Menu();
            menu = this.menuDataContext.Menu.SingleOrDefault(o => o.MenuID == menuID);
            return menu;
        }
        public Menu GetMenuByName(string menuName)
        {
            Menu menu = new Menu();
            menu = this.menuDataContext.Menu.SingleOrDefault(o => o.MenuName == menuName);
            return menu;
        }

        public List<string> GetMenusByMenuName(string menuName)
        {
            var q = from p in menuDataContext.Menu where p.MenuName.Contains(menuName) select p.MenuName;
            return q.ToList();
            //return this.menuDataContext.Menu.Where(o => o.MenuName.Contains(menuName)).ToList();
        }

        public bool DeleteMenuByMenuID(string menuID)
        {
            try
            {
                Menu menu = this.menuDataContext.Menu.SingleOrDefault(o => o.MenuID == menuID);
                this.menuDataContext.Menu.DeleteOnSubmit(menu);
                this.menuDataContext.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }

        public bool UpdataMenu(Menu menu)
        {
            try
            {
                menuDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}

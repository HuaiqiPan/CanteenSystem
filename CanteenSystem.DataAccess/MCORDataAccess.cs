using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class MCORDataAccess
    {
        MenuCheckedOrder_RDataContext MenuCheckedOrder_RDataContext;
        //构造方法
        public MCORDataAccess()
        {
            this.MenuCheckedOrder_RDataContext = new MenuCheckedOrder_RDataContext();
        }
        //查询所有用户信息
        public List<MenuCheckedOrder_R> GetAllMCOR()
        {
            return this.MenuCheckedOrder_RDataContext.MenuCheckedOrder_R.ToList();
        }
        //通过订单ID查询该订单的内容
        public List<MenuCheckedOrder_R> GetMCORByCheckedOrderID(string checkedOrderID)
        {
            List<MenuCheckedOrder_R> mroList = new List<MenuCheckedOrder_R>();
            mroList = this.MenuCheckedOrder_RDataContext.MenuCheckedOrder_R.Where(o => o.CheckedOrderID.Contains(checkedOrderID)).ToList();
            return mroList;
        }

        public MenuCheckedOrder_R GetMenuCheckedOrder_RByID(string ID)
        {
            MenuCheckedOrder_R mor = new MenuCheckedOrder_R();
            mor = this.MenuCheckedOrder_RDataContext.MenuCheckedOrder_R.SingleOrDefault(o => o.MenuCheckedOrderID == ID);
            return mor;
        }
        //添加用户
        public bool AddMCOR(MenuCheckedOrder_R MCOR)
        {
            try
            {
                this.MenuCheckedOrder_RDataContext.MenuCheckedOrder_R.InsertOnSubmit(MCOR);
                this.MenuCheckedOrder_RDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //通过主键
        public bool DeleteMCORById(string checkedOrderID)
        {
            try
            {
                MenuCheckedOrder_R MOR = this.MenuCheckedOrder_RDataContext.MenuCheckedOrder_R.SingleOrDefault(o => o.CheckedOrderID == checkedOrderID);
                this.MenuCheckedOrder_RDataContext.MenuCheckedOrder_R.DeleteOnSubmit(MOR);
                this.MenuCheckedOrder_RDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdataMOR(MenuCheckedOrder_R MOR)
        {
            try
            {
                MenuCheckedOrder_RDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

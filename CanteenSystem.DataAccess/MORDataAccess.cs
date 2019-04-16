using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CanteenSystem.DataAccess
{
   public class MORDataAccess
    {
        MenuOrder_RDataContext MORDataContext;
        //构造方法
        public MORDataAccess()
        {
            this.MORDataContext = new MenuOrder_RDataContext();
        }


        //查询所有用户信息
        public List<MenuOrder_R> GetAllMOR()
        {
            return this.MORDataContext.MenuOrder_R.ToList();
        }

        public DataTable GetMOR(string orderID)
        {

            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("MenuOrderID");
            DataColumn dc2 = new DataColumn("OrderID");
            DataColumn dc3 = new DataColumn("菜名");
            DataColumn dc4 = new DataColumn("单位");
            DataColumn dc5 = new DataColumn("报价");
            DataColumn dc6 = new DataColumn("优惠率");
            DataColumn dc7 = new DataColumn("价格");
            DataColumn dc8 = new DataColumn("数量");
            DataColumn dc9 = new DataColumn("金额");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            dt.Columns.Add(dc8);
            dt.Columns.Add(dc9);
            
            this.MORDataContext.MenuOrder_R.Where(o => o.OrderID.Contains(orderID)).ToList().ForEach(o => dt.Rows.Add(o.MenuOrderID, o.OrderID
                ,o.MenuName, o.Unit, o.Quote,o.Rate,o.Price,o.Count,o.Money));
            return dt;
        }
        //通过订单ID查询该订单的内容
        public List<MenuOrder_R> GetMORByOrderID(string orderID)
        {
            List<MenuOrder_R> mroList = new List<MenuOrder_R>();
            mroList = this.MORDataContext.MenuOrder_R.Where(o => o.OrderID.Contains(orderID)).ToList();
            return mroList;
        }

        public MenuOrder_R GetMenuOrder_RByID(string ID)
        {
            MenuOrder_R mor = new MenuOrder_R();
            mor = this.MORDataContext.MenuOrder_R.SingleOrDefault(o => o.MenuOrderID == ID);
            return mor;
        }
        //添加用户
        public bool AddMOR(MenuOrder_R MOR)
        {
            try
            {
                this.MORDataContext.MenuOrder_R.InsertOnSubmit(MOR);
                this.MORDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //通过主键
        public bool DeleteMORById(string orderID)
        {
            try
            {
                MenuOrder_R MOR = this.MORDataContext.MenuOrder_R.SingleOrDefault(o => o.OrderID == orderID);
                this.MORDataContext.MenuOrder_R.DeleteOnSubmit(MOR);
                this.MORDataContext.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }
        public bool UpdataMOR(MenuOrder_R MOR)
        {
            try
            {
                MORDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        //通过OrderID删除一个订单的对应关系
        /*   public bool DeleteMORByOrderID(string orderID)
           {
               try
               {
                   List<Menu_Order_R> mroList = new List<Menu_Order_R>();
                   mroList = this.MORDataContext.Menu_Order_R.Where(o => o.OrderID.Contains(orderID)).ToList();
                   this.MORDataContext.Menu_Order_R.DeleteOnSubmit(MOR);
                   this.MORDataContext.SubmitChanges();
                   return true;

               }
               catch
               {
                   return false;
               }

           }*/
    }
}

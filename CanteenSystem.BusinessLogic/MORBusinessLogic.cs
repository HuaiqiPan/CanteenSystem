using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class MORBusinessLogic
    {
        MORDataAccess mORDataAccess;
        public MORBusinessLogic()
        {
            this.mORDataAccess = new MORDataAccess();
        }

        public DataTable GetMOR(string orderID)
        {
            //DataTable dt = new DataTable();
            //DataColumn dc1 = new DataColumn("菜名1");
            //DataColumn dc2 = new DataColumn("菜名2");
            //dt.Columns.Add(dc1);
            //dt.Columns.Add(dc2);
            return mORDataAccess.GetMOR(orderID);
        }
        public List<MenuOrder_R> GetMORByOrderID(string orderID)
        {
            return mORDataAccess.GetMORByOrderID(orderID);
        }
        public bool AddMOR(MenuOrder_R MOR)
        {
            return mORDataAccess.AddMOR(MOR);
        }
        public MenuOrder_R GetMenuOrder_RByID(string ID)
        {
            return mORDataAccess.GetMenuOrder_RByID(ID);
        }
        public bool UpdataMOR(MenuOrder_R MOR)
        {
            return mORDataAccess.UpdataMOR(MOR);
        }
    }
}

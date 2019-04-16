using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class MCORBusinessLogic
    {
        MCORDataAccess mCORDataAccess;
        
        //构造方法
        public MCORBusinessLogic()
        {
            this.mCORDataAccess = new MCORDataAccess();
        }
        public List<MenuCheckedOrder_R> GetAllMCOR()
        {
            return this.mCORDataAccess.GetAllMCOR();
        }
        //通过订单ID查询该订单的内容
        public List<MenuCheckedOrder_R> GetMCORByCheckedOrderID(string checkedOrderID)
        {
            return mCORDataAccess.GetMCORByCheckedOrderID(checkedOrderID);
        }

        public MenuCheckedOrder_R GetMenuCheckedOrder_RByID(string ID)
        {
            return mCORDataAccess.GetMenuCheckedOrder_RByID(ID);
        }
        
        public bool AddMCOR(MenuCheckedOrder_R MCOR)
        {
            return mCORDataAccess.AddMCOR(MCOR);
        }

        //通过主键
        public bool DeleteMCORById(string checkedOrderID)
        {
            return mCORDataAccess.DeleteMCORById(checkedOrderID);

        }
        public bool UpdataMOR(MenuCheckedOrder_R MOR)
        {
            return mCORDataAccess.UpdataMOR(MOR);

        }
    }
}

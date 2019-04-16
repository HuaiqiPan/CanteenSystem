using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenSystem.Model;
using CanteenSystem.DataAccess;

namespace CanteenSystem.BusinessLogic
{
    public class CanteenOrderBusinessLogic
    {
        CanteenOrderDataAccess canteenOrderDataAccess;

        public CanteenOrderBusinessLogic()
        {
            canteenOrderDataAccess = new CanteenOrderDataAccess();
        }

        public List<CanteenOrder> GetAll()
        {
            return canteenOrderDataAccess.GetAll();
        }

        public CanteenOrder GetCanteenOrderByKeyID(string CanteenOrderKeyID)
        {
            return canteenOrderDataAccess.GetCanteenOrderByKeyID(CanteenOrderKeyID);
        }

        public List<CanteenOrder> GetCanteenOrderByName(string CanteenOrderName)
        {
            return canteenOrderDataAccess.GetCanteenOrderByName(CanteenOrderName);
        }

        public bool Add(CanteenOrder canteenOrder)
        {
            return canteenOrderDataAccess.Add(canteenOrder);
        }

        public bool Update(CanteenOrder canteenOrder)
        {
            return canteenOrderDataAccess.Update(canteenOrder);
        }

        public bool delete(string CanteenOrderKeyID)
        {
            return canteenOrderDataAccess.delete(CanteenOrderKeyID);
        }

        public bool delete(CanteenOrder canteenOrder)
        {
            return canteenOrderDataAccess.delete(canteenOrder);
        }
    }
}

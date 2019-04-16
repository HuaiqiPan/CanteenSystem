using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class UGRBusinessLogic
    {
        UGRDataAccess ugrDataAccess;
        public UGRBusinessLogic()
        {
            this.ugrDataAccess = new UGRDataAccess();
        }
        public bool AddUGR(UsersGroup_R ugr)
        {
            return this.ugrDataAccess.AddUGR(ugr);

        }
        public bool DeleteUGR(UsersGroup_R ugr)
        {
            return this.ugrDataAccess.DeleteUGR(ugr);
        }
        public bool DeleteUGRByID(string ugrID)
        {
            return this.ugrDataAccess.DeleteUGRByID(ugrID);
        }
        public List<UsersGroup_R> GetAllUGR()
        {
            return this.ugrDataAccess.GetAllUGR();
        }
       
        public bool UpdataUGR(UsersGroup_R ugr)
        {
            return this.UpdataUGR(ugr);

        }
    }
    
   
}

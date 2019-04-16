using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class UGRDataAccess
    {
        Users_Group_RDataContext users_Group_RDataContext;
        public UGRDataAccess()
        {
            this.users_Group_RDataContext = new Users_Group_RDataContext();
        }
        public bool AddUGR(UsersGroup_R ugr)
        {
            try
            {
                this.users_Group_RDataContext.UsersGroup_R.InsertOnSubmit(ugr);
                this.users_Group_RDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            
        }
        public bool DeleteUGR(UsersGroup_R ugr)
        {
            try
            {
                this.users_Group_RDataContext.UsersGroup_R.DeleteOnSubmit(ugr);
                this.users_Group_RDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public List<UsersGroup_R> GetAllUGR()
        {
            return this.users_Group_RDataContext.UsersGroup_R.ToList();
        }
        public bool DeleteUGRByID(string ugrID)
        {
            try
            {
                UsersGroup_R ugr = this.users_Group_RDataContext.UsersGroup_R.SingleOrDefault(o => o.UsersGroup_ID == ugrID);
                this.users_Group_RDataContext.UsersGroup_R.DeleteOnSubmit(ugr);
                this.users_Group_RDataContext.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }
        public bool UpdataUGR(UsersGroup_R ugr)
        {
            try
            {
                users_Group_RDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class View_GroupBusinessLogic
    {
        View_GroupDataAccess view_GroupDataAccess;
        public View_GroupBusinessLogic()
        {
            this.view_GroupDataAccess = new View_GroupDataAccess();
        }

        public List<View_Group> GetAllView_Group()
        {
            return this.view_GroupDataAccess.GetAllView_Group();
        }
        public List<View_Group> GetView_GroupByGroupID(string groupID)
        {
            return this.view_GroupDataAccess.GetView_GroupByGroupID(groupID);
        }
        public View_Group GetView_GroupByUserID(string userID)
        {
            return this.view_GroupDataAccess.GetView_GroupByUserID(userID);
        }
     }
}

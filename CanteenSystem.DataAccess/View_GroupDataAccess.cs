using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class View_GroupDataAccess
    {
        View_GroupDataContext view_GroupDataContext;
        public View_GroupDataAccess()
        {
            this.view_GroupDataContext = new View_GroupDataContext();
        }

        public List<View_Group> GetAllView_Group()
        {
            return this.view_GroupDataContext.View_Group.ToList();
        }
        public List<View_Group> GetView_GroupByGroupID(string groupID)
        {
            List<View_Group> view_GroupList = new List<View_Group>();
            view_GroupList = this.view_GroupDataContext.View_Group.Where(o => o.GroupID.Contains(groupID)).ToList();
            return view_GroupList;
        }
        public View_Group GetView_GroupByUserID(string userID)
        {
            View_Group view_Group = new View_Group();
            view_Group = this.view_GroupDataContext.View_Group.SingleOrDefault(o => o.UserID == userID);
            return view_Group;
        }
    }
}

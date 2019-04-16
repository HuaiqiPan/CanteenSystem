using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class GroupBusinessLogic
    {
        GroupDataAccess groupDataAccess;
        public GroupBusinessLogic()
        {
            this.groupDataAccess = new GroupDataAccess();
        }
        public List<Group> GetAllGroup()
        {
            return this.groupDataAccess.GetAllGroup();
        }
        public Group GetGroupByGroupname(string groupname)
        {
            return this.groupDataAccess.GetGroupByGroupname(groupname);
        }
        public Group GetGroupByID(string groupID)
        {

            return this.groupDataAccess.GetGroupByID(groupID);
        }
        public bool AddGroup(Group group)
        {
            return this.groupDataAccess.AddGroup(group);
        }
        public bool DeleteGroupById(string groupID)
        {
            return this.groupDataAccess.DeleteGroupById(groupID);
        }
        public bool UpdataGroup(Group group)
        {
            return this.groupDataAccess.UpdataGroup(group);
        }
        //通过groupID获取该group的user
        public List<Users> GetGroupMenber(string groupID)
        {

            return this.groupDataAccess.GetGroupMenber(groupID);
        }
    }
}

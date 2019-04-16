using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class GroupDataAccess
    {
        GroupDataContext groupDataContext;
        Users_Group_RDataContext users_Group_RDataContext;
        UsersDataContext userDataContext;

        //构造方法
        public GroupDataAccess()
        {
            this.groupDataContext = new GroupDataContext();
            this.users_Group_RDataContext = new Users_Group_RDataContext();
            this.userDataContext = new UsersDataContext();
        }
        public List<Group> GetAllGroup()
        {
            return this.groupDataContext.Group.ToList();
        }  
        public Group GetGroupByGroupname(string groupname)
        {
            Group group = new Group();
            group = this.groupDataContext.Group.FirstOrDefault(o => o.GroupName == groupname);
            return group;
        }
        public Group GetGroupByID(string groupID)
        {
            Group group = new Group();
            group = this.groupDataContext.Group.SingleOrDefault(o => o.GroupID == groupID);
            return group;
        }
        public bool AddGroup(Group group)
        {
            try
            {
                this.groupDataContext.Group.InsertOnSubmit(group);
                this.groupDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //通过groupID获取该group的user
        public List<Users> GetGroupMenber(string groupID)
        {
            List<string> userIDList = users_Group_RDataContext.UsersGroup_R.Where(o => o.GroupID == groupID).Select(o => o.UserID).ToList();
            List<Users> userList = userDataContext.Users.Where(o => userIDList.Contains(o.UserID)).ToList();
            return userList;
        }
        public bool DeleteGroupById(string groupID)
        {
            try
            {
                Group group = this.groupDataContext.Group.SingleOrDefault(o => o.GroupID == groupID);
                this.groupDataContext.Group.DeleteOnSubmit(group);
                this.groupDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdataGroup(Group group)
        {
            try
            {
                this.groupDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

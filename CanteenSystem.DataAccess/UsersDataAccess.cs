using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenSystem.Model;

namespace CanteenSystem.DataAccess
{
    public class UsersDataAccess
    {
        UsersDataContext usersDataContext;

        //构造方法
        public UsersDataAccess()
        {
            this.usersDataContext = new UsersDataContext();
        }


        //查询所有用户信息
        public List<Users> GetAllUsers()
        {
            return this.usersDataContext.Users.ToList();
        }

        //通过用户账号查询用户信息
        public Users GetUsersByUsername(string username)
        {
            Users user = new Users();
            user = this.usersDataContext.Users.FirstOrDefault(o=>o.UserName==username);
            return user;
        }
        //通过用户真实姓名查询用户信息
        public Users GetUsersByUserrealname(string userrealname)
        {
            Users user = new Users();
            user = this.usersDataContext.Users.FirstOrDefault(o => o.RealName == userrealname);
            return user;
        }

        //通过主键userID查询单个用户信息
        public Users GetUserByID(string userID)
        {
            Users user = new Users();
            user = this.usersDataContext.Users.SingleOrDefault(o => o.UserID == userID);
            return user;
        }

        //添加用户
        public bool AddUser(Users user)
        {
            try
            {
                this.usersDataContext.Users.InsertOnSubmit(user);
                this.usersDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        //通过主键UserId删除单个用户
        public bool DeleteUserById(string userID)
        {
            try
            {
                Users user = this.usersDataContext.Users.SingleOrDefault(o => o.UserID == userID);
                this.usersDataContext.Users.DeleteOnSubmit(user);
                this.usersDataContext.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
            
        }

        //更改用户信息
        public bool UpdataUser(Users user)
        {
            try
            {
                this.usersDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

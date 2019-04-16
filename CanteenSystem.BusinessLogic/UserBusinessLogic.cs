using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenSystem.DataAccess;
using CanteenSystem.Model;

namespace CanteenSystem.BusinessLogic
{
    public class UserBusinessLogic
    {
        UsersDataAccess usersDateAccess;
        public UserBusinessLogic()
        {
            usersDateAccess = new UsersDataAccess();
        }

        //查询所有用户信息
        public List<Users> GetUsers()
        {
            return usersDateAccess.GetAllUsers();
        }

        //通过主键userID查询单个用户信息
        public Users GetUserByID(string userID)
        {
            return usersDateAccess.GetUserByID(userID);
        }
        //通过用户名字查询用户信息
        public Users GetUsersByUsername(string username)
        {

            return usersDateAccess.GetUsersByUsername(username);
        }
        public Users GetUsersByUserrealname(string userrealname)
        {
            return usersDateAccess.GetUsersByUserrealname(userrealname);
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>是否添加成功</returns>
        public bool AddUser(Users user)
        {
            return usersDateAccess.AddUser(user);

        }

        //通过主键UserId删除单个用户
        public bool DeleteUsersById(string userID)
        {
            return usersDateAccess.DeleteUserById(userID);
        }

        //更改用户信息
        public bool UpdataUsers(Users user)
        {
            return usersDateAccess.UpdataUser(user);
        }
    }
}

using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanteenSystem.BusinessLogic;
using System.Security.Cryptography;
using System.Net.Http;
using CanteenSystem.banzu;
using CanteenSystem.Main;

namespace CanteenSystem
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            string username = txbUserName.Text.Trim();
            string password = txbPassword.Text.Trim();
            UserBusinessLogic usersLogicBusiness = new UserBusinessLogic();
            user=usersLogicBusiness.GetUsersByUsername(username);
            if (user==null)
            {
                MessageBox.Show("该用户不存在！");
            }
            else
            {
                byte[] input = Encoding.Default.GetBytes(this.txbPassword.Text.Trim());
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(input);
                password = BitConverter.ToString(output).Replace("-", "");
                if (user.Password == password)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(user.UserID, this);
                    mainForm.Show();
                    
                }
                else
                {
                    MessageBox.Show("密码不正确，请重新输入！");
                }
            }
            
        }

        /// <summary>
        /// 按回车键登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">密码框输入回车键时触发的事件</param>
        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogin_Click(sender, e);
                
            }
            
        }
    }
}

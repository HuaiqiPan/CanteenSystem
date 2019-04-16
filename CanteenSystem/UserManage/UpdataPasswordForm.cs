using CanteenSystem.BusinessLogic;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenSystem.UserManage
{
    public partial class UpdataPasswordForm : Form
    {
        UserBusinessLogic userbusinessLogic = new UserBusinessLogic();
        Users user=new Users();
        public UpdataPasswordForm(string userID)
        {
            InitializeComponent();
            user = userbusinessLogic.GetUserByID(userID);
            Console.WriteLine(user.Password);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            byte[] input = Encoding.Default.GetBytes(this.txbOldPassword.Text.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(input);
            string oldPassword = BitConverter.ToString(output).Replace("-", "");
            string newPassword1 = txbNewPassword1.Text.Trim();
            string newPassword2 = txbNewPassword2.Text.Trim();
            if (oldPassword!=user.Password)
            {
                MessageBox.Show("密码不正确，请重新输入！");
                return;
            }
            if (newPassword1!=newPassword2)
            {
                MessageBox.Show("两次输入密码不一致，请重新输入！");
                return;
            }
            else
            {
                byte[] beforemd5 = Encoding.Default.GetBytes(newPassword2);
                MD5 m = new MD5CryptoServiceProvider();
                byte[] aftermd5 = m.ComputeHash(beforemd5);
                this.user.Password = BitConverter.ToString(aftermd5).Replace("-", "");
                try
                {
                    if (userbusinessLogic.UpdataUsers(this.user))
                    {
                        MessageBox.Show("修改成功！请重新登录");
                        this.Close();
                        Application.Restart();

                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                catch
                {

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

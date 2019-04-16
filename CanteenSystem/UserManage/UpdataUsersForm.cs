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

namespace CanteenSystem
{
    public partial class UpdataUsersForm : Form
    {
        UserBusinessLogic userBusinessLogic = new UserBusinessLogic();
        Users user = new Users();
        public UpdataUsersForm(string KeyID)
        {
            InitializeComponent();
            
            user = userBusinessLogic.GetUserByID(KeyID);
            txbUserName.Text = user.UserName;
            //txbPassword.Text = user.Password;
            txbRealName.Text = user.RealName;
            txbSex.Text = user.Sex;
            dtpBirthday.Text = user.Birthday.ToString();
            txbMobile.Text = user.Mobile;
            txbRemark.Text = user.Remark;
        }

        private void UpdataUsersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            user.UserName = txbUserName.Text.Trim();
            //byte[] password = Encoding.Default.GetBytes(this.txbPassword.Text.Trim());
            //MD5 md5 = new MD5CryptoServiceProvider();
            //byte[] output = md5.ComputeHash(password);
            //user.Password = BitConverter.ToString(output).Replace("-", "");
            user.RealName = txbRealName.Text.Trim();
            user.Sex = txbSex.Text.Trim();
            user.Birthday = Convert.ToDateTime(dtpBirthday.Text);
            user.Mobile = txbMobile.Text.Trim();
            user.Remark = txbRemark.Text.Trim();  
            try
            {
                if (userBusinessLogic.UpdataUsers(user))
                {
                    MessageBox.Show("修改成功！");
                    this.Close();
                   
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using CanteenSystem.BusinessLogic;
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
using System.Security.Cryptography;
using System.Globalization;

namespace CanteenSystem
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            cbxSex.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            Users user = new Users();
            user.UserID = Guid.NewGuid().ToString();
            user.UserName = txbUserName.Text.Trim();
            byte[] password = Encoding.Default.GetBytes(this.txbpassword.Text.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(password);
            user.Password = BitConverter.ToString(output).Replace("-", "");
            user.RealName = txbRealName.Text.Trim();
            user.Sex = cbxSex.SelectedItem.ToString();
            //DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();
            //dtFormat.ShortDatePattern = "yyyy/MM/dd";
            //user.Birthday = Convert.ToDateTime(dtpBirthday.Text,dtFormat);
            user.Birthday = Convert.ToDateTime(dtpBirthday.Text);
            user.Mobile = txbMobile.Text.Trim();
            user.Remark = txbMemo.Text.Trim();
            user.InputDate = DateTime.Now;
            UserBusinessLogic userBusinessLogic = new UserBusinessLogic();
            try
            {
               if(userBusinessLogic.AddUser(user))
                {
                    MessageBox.Show("添加成功！");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            catch
            {
                
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbUserName.Text="";
            txbpassword.Text="";
            txbRealName.Text="";
            txbMemo.Text="";
            //this.Hide();
            this.Close();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

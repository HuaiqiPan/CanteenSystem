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

namespace CanteenSystem.UserManage
{
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GroupBusinessLogic groupBusinessLogic = new GroupBusinessLogic();
            Group group = new Group();
            bool flag = false;
            group.GroupID = Guid.NewGuid().ToString();
            group.GroupName = txbGroupName.Text.Trim();
            group.GroupDescription = txbDescription.Text.Trim();
            group.InputDate = DateTime.Now;
            if (comboBox1.Text=="")
            {
                MessageBox.Show("请在备注栏选择部门类别！");
                return;
            }
            else
            {
                group.Remark = comboBox1.Text.Trim();
                flag = groupBusinessLogic.AddGroup(group);
            }
            if (flag)
            {
                MessageBox.Show("添加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbGroupName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

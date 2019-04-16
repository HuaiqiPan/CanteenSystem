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
    public partial class EditGroupForm : Form
    {
        GroupBusinessLogic groupBusinessLogic = new GroupBusinessLogic();
        Group group = new Group();
        public EditGroupForm(string groupID)
        {
            InitializeComponent();
            group = groupBusinessLogic.GetGroupByID(groupID);
            txbGroupName.Text= group.GroupName;
            txbDescription.Text=group.GroupDescription;
            comboBox1.Text= group.Remark;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = false;
            group.GroupName = txbGroupName.Text.Trim();
            group.GroupDescription = txbDescription.Text.Trim();
            if (comboBox1.Text.Trim()=="")
            {
                MessageBox.Show("请在备注栏选择部门类型！");
                return;
            }
            else
            {
                group.Remark = comboBox1.Text.Trim();
                flag = groupBusinessLogic.UpdataGroup(group);
            }
            if (flag)
            {
                MessageBox.Show("修改成功！");
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
    }
}

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
using CanteenSystem.Model;
using CanteenSystem;
using static CanteenSystem.UserManage.CanteenDBDataSet;

namespace CanteenSystem
{
    public partial class UserManageForm : Form
    {
        public List<string> selectedKeyIDList=new List<string>();
        public UserManageForm()
        {
            InitializeComponent();
        }

        private void UserManageForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“canteenDBDataSet.Users”中。您可以根据需要移动或删除它。
            this.usersTableAdapter.Fill(this.canteenDBDataSet.Users);

        }

        private void btnGetUser_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text.Trim();
            List<Users> SelectList = new List<Users>();
            Users user = new Users();
            UserBusinessLogic userBusinessLogic = new UserBusinessLogic();
            user=userBusinessLogic.GetUsersByUserrealname(username);
            if (user != null)   
            {
                SelectList.Add(user);
                dgvUsers.DataSource = SelectList;
            }else
            {
                MessageBox.Show("该用户不存在！");
            }
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
            UserManageForm_Load(sender, e);
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (selectedKeyIDList.Count==0)
            {
                MessageBox.Show("请选择要删除的用户！");
            }
            else
            {
                foreach (string userID in selectedKeyIDList)
                {
                    UserBusinessLogic userBusinessLogic = new UserBusinessLogic();
                    flag = userBusinessLogic.DeleteUsersById(userID);
                }
                if (!flag)
                {
                    MessageBox.Show("删除失败！");
                }
                else
                {
                    MessageBox.Show("删除成功！");
                }
            }
            this.dgvUsers.DataSource = this.usersBindingSource;
            UserManageForm_Load(sender, e);
            selectedKeyIDList.Clear();
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            UserManageForm_Load(sender,e);
            this.dgvUsers.DataSource = this.usersBindingSource;
        }

        /// <summary>
        /// 单元格单击触发事件
        /// </summary>
        /// <param name="sender">传递事件控件</param>
        /// <param name="e">触发的事件</param>
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //删除
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dgvUsers.Rows[e.RowIndex].Cells[0]);
                string UserID = this.dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                {
                    selectedKeyIDList.Add(UserID);
                }
                else
                {
                    selectedKeyIDList.Remove(UserID);
                }
            }
            else if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                string UserID = this.dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                UpdataUsersForm updataUsersForm = new UpdataUsersForm(UserID);
                updataUsersForm.ShowDialog();
                UserManageForm_Load(sender, e);
            }
        }
    }
}

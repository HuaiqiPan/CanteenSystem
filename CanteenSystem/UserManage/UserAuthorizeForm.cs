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
    public partial class UserAuthorizeForm : Form
    {
        GroupBusinessLogic groupBusinessLogic;
        UGRBusinessLogic ugrBusinessLogic;
        UserBusinessLogic userBusinessLogic;
        View_GroupBusinessLogic view_GroupBusinessLogic;
        public UserAuthorizeForm()
        {
            InitializeComponent();
            this.groupBusinessLogic = new GroupBusinessLogic();
            this.ugrBusinessLogic = new UGRBusinessLogic();
            this.userBusinessLogic = new UserBusinessLogic();
            this.view_GroupBusinessLogic = new View_GroupBusinessLogic();
            LoadGroup(); 
            LoadUsers();
            SetdgvUGRColumns();
            SetdgvUserColumns();
            txbGroupID.Visible = false;
            txbugrID.Visible = false;
            txbUserID.Visible = false;
        }
        public void LoadGroup()
        {
            List<Group> groupList = new List<Group>();
            groupList = groupBusinessLogic.GetAllGroup();
            dgvUGR.DataSource = groupList;
        }
        public void LoadUsers()
        {
            List<Users> userList = new List<Users>();
            userList = userBusinessLogic.GetUsers();
            dgvusers.DataSource = userList;
        }
        public void SetdgvUGRColumns()
        {
            //dgvUGR.Columns[0].HeaderText = "班组编号";
            dgvUGR.Columns[0].Visible = false;
            dgvUGR.Columns[1].HeaderText = "班组名称";
            dgvUGR.Columns[1].Width = 80;
            dgvUGR.Columns[2].HeaderText = "班组描述";
            dgvUGR.Columns[3].HeaderText = "创建时间";
            dgvUGR.Columns[4].HeaderText = "备注";
            DataGridViewLinkColumn editeLinkColumn = new DataGridViewLinkColumn();
            editeLinkColumn.Text = "编辑";
            editeLinkColumn.Width = 35;
            editeLinkColumn.UseColumnTextForLinkValue = true;
            dgvUGR.Columns.Insert(5, editeLinkColumn);
            DataGridViewLinkColumn deleteLinkColumn = new DataGridViewLinkColumn();
            deleteLinkColumn.Text = "删除";
            deleteLinkColumn.Width = 35;
            deleteLinkColumn.UseColumnTextForLinkValue = true;
            dgvUGR.Columns.Insert(6, deleteLinkColumn);
            

        }
        public void SetdgvUserColumns()
        {
            dgvusers.Columns[0].Visible = false;
            //dgvusers.Columns[1].Visible = false;
            dgvusers.Columns[1].HeaderText = "账号";
            dgvusers.Columns[2].Visible = false;
            dgvusers.Columns[3].HeaderText="用户名";
            //dgvusers.Columns[3].Visible = false;
            dgvusers.Columns[4].Visible = false;
            dgvusers.Columns[5].Visible = false;
            dgvusers.Columns[6].Visible = false;
            dgvusers.Columns[7].Visible = false;
            dgvusers.Columns[8].Visible = false;
            dgvusers.Columns[9].Visible = false;
            dgvusers.Columns[10].Visible = false;
            dgvusers.Columns[11].Visible = false;
            dgvusers.Columns[12].Visible = false;
        }
        public void SetdgvUserInGroupColumns()
        {
            dgvUserInGroup.Columns[0].Visible = false;
            dgvUserInGroup.Columns[1].Visible = false;
            dgvUserInGroup.Columns[2].Visible = false;
            dgvUserInGroup.Columns[3].HeaderText = "账号";
            dgvUserInGroup.Columns[4].HeaderText = "用户名";
            dgvUserInGroup.Columns[5].HeaderText = "班组名称";
            dgvUserInGroup.Columns[6].HeaderText = "部门类型";
        }
        //授权用户的方法，将用户列入某个组
        public void Authorize(string groupID,string userID)
        {
            UsersGroup_R ugr = new UsersGroup_R();
            ugr.UsersGroup_ID = Guid.NewGuid().ToString();
            ugr.UserID = userID;
            ugr.GroupID = groupID;
            if (ugrBusinessLogic.AddUGR(ugr))
            {
                MessageBox.Show("授权成功！");
            }
            else
            {
                MessageBox.Show("授权失败！");
            }
        }
        private void UserAuthorizeForm_Load(object sender, EventArgs e)
        {
            
        }
        private void AddGroup_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm();
            addGroupForm.ShowDialog();
            LoadGroup();
        }
        private void dgvUGR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupBusinessLogic groupBusinessLogic = new GroupBusinessLogic();
            View_GroupBusinessLogic view_GroupBusinessLogic = new View_GroupBusinessLogic();
            //单击班组名称显示该班组成员
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                string groupID = this.dgvUGR.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.dgvUserInGroup.DataSource = view_GroupBusinessLogic.GetView_GroupByGroupID(groupID);
                SetdgvUserInGroupColumns();
                txbGroupID.Text = groupID;
            }
            //单击编辑执行的操作
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string groupID = this.dgvUGR.Rows[e.RowIndex].Cells[2].Value.ToString();
                EditGroupForm editGroupForm = new EditGroupForm(groupID);
                editGroupForm.ShowDialog();
                this.dgvUGR.DataSource = groupBusinessLogic.GetAllGroup();
            }
            //单击删除执行的操作
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                DialogResult result = MessageBox.Show("确定删除该组？", "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string groupID = this.dgvUGR.Rows[e.RowIndex].Cells[2].Value.ToString();
                    groupBusinessLogic.DeleteGroupById(groupID);//删除已经做级联                 
                    MessageBox.Show("删除成功！");
                    LoadGroup();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string groupID;
            string userID;
            groupID = txbGroupID.Text.Trim();
            userID = txbUserID.Text.Trim();
            if (groupID=="")
            {
                MessageBox.Show("请选择要添加的组别！");
                return;
            }
            if (userID=="")
            {
                MessageBox.Show("请选择要添加的用户！");
                return;
            }
            Authorize(groupID,userID);
            this.dgvUserInGroup.DataSource = view_GroupBusinessLogic.GetView_GroupByGroupID(groupID);
            SetdgvUserInGroupColumns();
        }

        private void dgvusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
            if (e.RowIndex != -1)
            {
                string userID;
                userID = this.dgvusers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbUserID.Text = userID;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string ugrID;
            ugrID = txbugrID.Text.Trim();
            string groupID;
            groupID = txbGroupID.Text.Trim();
            if (ugrID=="")
            {
                MessageBox.Show("请选择要移除的用户！");
                return;
            }
            if (ugrBusinessLogic.DeleteUGRByID(ugrID))
            {
                MessageBox.Show("移除成功！");
                this.dgvUserInGroup.DataSource = view_GroupBusinessLogic.GetView_GroupByGroupID(groupID);
            }
            else
            {
                MessageBox.Show("移除失败！");
            }           
        }

        private void dgvUserInGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string ugrID;
                string groupID;
                ugrID = this.dgvUserInGroup.Rows[e.RowIndex].Cells[0].Value.ToString();
                groupID = this.dgvUserInGroup.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbugrID.Text = ugrID;
                txbGroupID.Text = groupID;
            }       
        }
    }
}

using CanteenSystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanteenSystem.Model;

namespace CanteenSystem.banzu
{
    public partial class BanzuForm : Form
    {
        UserBusinessLogic usersBusinessLogic = new UserBusinessLogic();
        MenuBusinessLogic menuBusinessLogic = new MenuBusinessLogic();
        PlanBusinessLogic planBusinessLogic = new PlanBusinessLogic();
        MORBusinessLogic mORBusinessLogic = new MORBusinessLogic();
        View_GroupBusinessLogic view_GroupBusinessLogic = new View_GroupBusinessLogic();


        Users user = new Users();
        Group group = new Group();
        View_Group view_Group = new View_Group();

        public BanzuForm(string userID)
        {
            user = usersBusinessLogic.GetUserByID(userID);
            view_Group = view_GroupBusinessLogic.GetView_GroupByUserID(userID);
            InitializeComponent();
            loadMenu();
            //loadMenuProvider();
            setColumn();
            //SetdgvMenuProvider_RColumns();
            SetdgvNoPassOrderColumns();
            txbGroup.Text = view_Group.GroupName;
            txbCreator.Text = user.RealName;

        }
        public BanzuForm()
        {
            InitializeComponent();
            loadMenu();
            //loadMenuProvider();
            setColumn();
           // SetdgvMenuProvider_RColumns();
            txbGroup.Text = group.GroupName;
            txbCreator.Text = user.UserName;

        }

        //加载订单数据
        public void loadMenu()
        {
            OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
            List<Order> orderlist = orderBusinessLogic.GetOrderByStatus("未提交");
            dgvOrder.DataSource = orderlist;
            List<Order> submitOrderlist = orderBusinessLogic.GetOrderByStatus("未审核");
            dgvSubmitOrder.DataSource = submitOrderlist;
            List<Order> passOrderlist = orderBusinessLogic.GetOrderByStatus("审核通过");
            dgvPassOrder.DataSource = passOrderlist;
            List<Order> noPassOrderlist = orderBusinessLogic.GetOrderByStatus("不通过");
            this.dgvNoPassOrder.DataSource = noPassOrderlist;
            List<Model.Menu> menuList = menuBusinessLogic.GetAllMenu();
            dgvMenu.DataSource = menuList;

        }

        //private void loadMenuProvider()
        //{
        //    View_MenuProvider_RBusinessLogic view_MenuProvider_RBusinessLogic = new View_MenuProvider_RBusinessLogic();
        //    List<View_MenuProvider_R> view_MenuProvider_RList = new List<View_MenuProvider_R>();
        //    view_MenuProvider_RList = view_MenuProvider_RBusinessLogic.GetAllView_MenuProvider_R();
        //    dgvMenuProvider_R.DataSource = view_MenuProvider_RList;
        //}

        //初始化界面
        public void setColumn()
        {
            dgvMenu.Columns[0].HeaderText = "ID";
            dgvMenu.Columns[0].Visible = false;
            dgvMenu.Columns[1].HeaderText = "序号";
            dgvMenu.Columns[2].HeaderText = "菜名";
            dgvMenu.Columns[3].HeaderCell.Value = "单位";
            dgvMenu.Columns[4].HeaderCell.Value = "数量";
            //dgvMenu.Columns[5].Visible = false;
            dgvMenu.Columns[5].HeaderCell.Value = "价格";
            dgvMenu.Columns[6].HeaderCell.Value = "备注";
            dgvMenu.Columns[1].ReadOnly = true;
            dgvMenu.Columns[2].ReadOnly = true;
            dgvMenu.Columns[3].ReadOnly = true;

            dgvOrder.Columns[0].HeaderText = "订单号";
            dgvOrder.Columns[1].HeaderText = "序号";
            dgvOrder.Columns[2].HeaderText = "订单名";
            dgvOrder.Columns[3].HeaderText = "班组";
            dgvOrder.Columns[4].HeaderText = "下单人";
            dgvOrder.Columns[5].HeaderText = "下单时间";
            dgvOrder.Columns[5].Width = 180;
            dgvOrder.Columns[6].HeaderText = "审核者";
            dgvOrder.Columns[7].HeaderText = "状态";
            dgvOrder.Columns[8].HeaderText = "备注";
            DataGridViewLinkColumn editeLinkColumn = new DataGridViewLinkColumn();
            //editeLinkColumn.Name = "EditeOrder";
            editeLinkColumn.Text = "编辑";
            editeLinkColumn.Width = 35;
            editeLinkColumn.UseColumnTextForLinkValue = true;
            dgvOrder.Columns.Insert(9, editeLinkColumn);
            DataGridViewLinkColumn deleteLinkColumn = new DataGridViewLinkColumn();
            //deleteLinkColumn.Name = "DeleteOrder";
            deleteLinkColumn.Text = "删除";
            deleteLinkColumn.Width = 35;
            deleteLinkColumn.UseColumnTextForLinkValue = true;
            dgvOrder.Columns.Insert(10, deleteLinkColumn);
            DataGridViewLinkColumn commitLinkColumn = new DataGridViewLinkColumn();
            //commitLinkColumn.Name = "SubmitOrder";
            commitLinkColumn.Text = "提交";
            commitLinkColumn.Width = 35;
            commitLinkColumn.UseColumnTextForLinkValue = true;
            dgvOrder.Columns.Insert(11, commitLinkColumn);

            dgvSubmitOrder.Columns[0].HeaderText = "订单号";
            dgvSubmitOrder.Columns[1].HeaderText = "序号";
            dgvSubmitOrder.Columns[2].HeaderText = "订单名";
            dgvSubmitOrder.Columns[3].HeaderText = "班组";
            dgvSubmitOrder.Columns[4].HeaderText = "下单人";
            dgvSubmitOrder.Columns[5].HeaderText = "下单时间";
            dgvSubmitOrder.Columns[5].Width = 200;
            dgvSubmitOrder.Columns[6].HeaderText = "审核者";
            dgvSubmitOrder.Columns[7].HeaderText = "状态";
            dgvSubmitOrder.Columns[8].HeaderText = "备注";
            DataGridViewLinkColumn lookLinkColumn = new DataGridViewLinkColumn();
            //lookLinkColumn.Name = "LookOrder";
            lookLinkColumn.Text = "查看";
            lookLinkColumn.UseColumnTextForLinkValue = true;
            dgvSubmitOrder.Columns.Insert(9, lookLinkColumn);


            dgvPassOrder.Columns[0].HeaderText = "订单号";
            dgvPassOrder.Columns[1].HeaderText = "序号";
            dgvPassOrder.Columns[2].HeaderText = "订单名";
            dgvPassOrder.Columns[3].HeaderText = "班组";
            dgvPassOrder.Columns[4].HeaderText = "下单人";
            dgvPassOrder.Columns[5].HeaderText = "下单时间";
            dgvPassOrder.Columns[5].Width = 200;
            dgvPassOrder.Columns[6].HeaderText = "审核者";
            dgvPassOrder.Columns[7].HeaderText = "状态";
            dgvPassOrder.Columns[8].HeaderText = "备注";
            DataGridViewLinkColumn LinkColumn = new DataGridViewLinkColumn();
            //LinkColumn.Name = "LookOrder";
            LinkColumn.Text = "查看";
            LinkColumn.UseColumnTextForLinkValue = true;
            dgvPassOrder.Columns.Insert(9, LinkColumn);
        }
        //public void SetdgvMenuProvider_RColumns()
        //{
        //    dgvMenuProvider_R.Columns[0].Visible = false;
        //    dgvMenuProvider_R.Columns[1].Visible = false;
        //    dgvMenuProvider_R.Columns[2].Visible = false;
        //    dgvMenuProvider_R.Columns[3].HeaderCell.Value = "菜名";
        //    dgvMenuProvider_R.Columns[4].HeaderCell.Value = "单位";
        //    dgvMenuProvider_R.Columns[5].HeaderCell.Value = "价格";
        //    dgvMenuProvider_R.Columns[6].HeaderCell.Value = "供应商";
        //}
        public void SetdgvNoPassOrderColumns()
        {
            dgvNoPassOrder.Columns[0].HeaderText = "订单号";
            dgvNoPassOrder.Columns[1].HeaderText = "序号";
            dgvNoPassOrder.Columns[2].HeaderText = "订单名";
            dgvNoPassOrder.Columns[3].HeaderText = "班组";
            dgvNoPassOrder.Columns[4].HeaderText = "下单人";
            dgvNoPassOrder.Columns[5].HeaderText = "下单时间";
            dgvNoPassOrder.Columns[5].Width = 200;
            dgvNoPassOrder.Columns[6].HeaderText = "审核者";
            dgvNoPassOrder.Columns[7].HeaderText = "状态";
            dgvNoPassOrder.Columns[8].HeaderText = "备注";
            DataGridViewLinkColumn LinkColumn = new DataGridViewLinkColumn();
            //LinkColumn.Name = "LookOrder";
            LinkColumn.Text = "查看";
            LinkColumn.UseColumnTextForLinkValue = true;
            dgvNoPassOrder.Columns.Insert(9, LinkColumn);
        }


        /// <summary>
        /// 单击保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            //OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
            ////new一个订单，并赋值，初始状态设为“未提交”
            //Order order = new Order();
            //order.OrderID = Guid.NewGuid().ToString();
            //order.Group = txbGroup.Text;
            //order.Creator = txbCreator.Text;
            //order.CreateTime = dtpOrderTime.Value;
            //order.Status = "未提交";
            //orderBusinessLogic.AddOrder(order);

            //int count = dgvMenu.Rows.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    if (dgvMenu.Rows[i].Cells[4].Value != null)
            //    {
            //        string menuID = dgvMenu.Rows[i].Cells[0].Value.ToString();
            //        MenuOrder_R MOR = new MenuOrder_R();
            //        MOR.MenuOrderID = Guid.NewGuid().ToString();
            //        MOR.RealCount = Convert.ToDouble(dgvMenu.Rows[i].Cells[4].Value);
            //        MOR.RealPrice = Convert.ToDouble(dgvMenu.Rows[i].Cells[5].Value);
            //        dgvMenu.Rows[i].Cells[4].Value = null;//清空
            //        if (dgvMenu.Rows[i].Cells[6].Value != null)
            //        {
            //            MOR.Remark = dgvMenu.Rows[i].Cells[6].Value.ToString();
            //        }
            //        MOR.MenuID = menuID;
            //        MOR.OrderID = order.OrderID;
            //        mORBusinessLogic.AddMOR(MOR);
            //    }

            //}
            //MessageBox.Show("保存成功！", "提示");
        }

        /// <summary>
        /// 单击提交按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntCommitOrder_Click(object sender, EventArgs e)
        {
            //OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
            ////new一个订单，并赋值，初始状态设为“未审核”
            //Order order = new Order();
            //order.OrderID = Guid.NewGuid().ToString();
            //order.Group = txbGroup.Text;
            //order.Creator = txbCreator.Text;
            //order.CreateTime = dtpOrderTime.Value;
            //order.Status = "未审核";
            //orderBusinessLogic.AddOrder(order);

            //int count = dgvMenu.Rows.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    if (dgvMenu.Rows[i].Cells[4].Value != null)
            //    {
            //        string menuID = dgvMenu.Rows[i].Cells[0].Value.ToString();
            //        MenuOrder_R MOR = new MenuOrder_R();
            //        MOR.MenuOrderID = Guid.NewGuid().ToString();
            //        MOR.RealCount = Convert.ToDouble(dgvMenu.Rows[i].Cells[4].Value);
            //        MOR.RealPrice = Convert.ToDouble(dgvMenu.Rows[i].Cells[5].Value);
            //        dgvMenu.Rows[i].Cells[4].Value = null;//清空
            //        if (dgvMenu.Rows[i].Cells[6].Value != null)
            //        {
            //            MOR.Remark = dgvMenu.Rows[i].Cells[6].Value.ToString();
            //        }
            //        MOR.MenuID = menuID;
            //        MOR.OrderID = order.OrderID;
            //        mORBusinessLogic.AddMOR(MOR);
            //    }

            //}
            //MessageBox.Show("提交成功！", "提示");

        }

        private void Uncommitted_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 单击选项卡事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
            if (this.tabControl1.SelectedIndex == 1)
            {
                List<Order> orderlist = orderBusinessLogic.GetOrderByStatus("未提交");
                this.dgvOrder.DataSource = orderlist;
            }
            else
                if (this.tabControl1.SelectedIndex == 2)
            {
                List<Order> submitOrderlist = orderBusinessLogic.GetOrderByStatus("未审核");
                this.dgvSubmitOrder.DataSource = submitOrderlist;
            }
            else
                if (this.tabControl1.SelectedIndex == 3)
            {
                List<Order> passOrderlist = orderBusinessLogic.GetOrderByStatus("审核通过");
                this.dgvPassOrder.DataSource = passOrderlist;
            }else
                if (this.tabControl1.SelectedIndex == 4)
            {
                List<Order> noPassOrderlist = orderBusinessLogic.GetOrderByStatus("不通过");
                this.dgvNoPassOrder.DataSource = noPassOrderlist;
            }

        }
        /// <summary>
        /// 单击操作列触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
            //单击编辑执行的操作
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string orderID = this.dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                OrderEditForm orderEditForm = new OrderEditForm(orderID, user);
                orderEditForm.ShowDialog();
                this.dgvOrder.DataSource = orderBusinessLogic.GetOrderByStatus("未提交");
            }
            //单击删除执行的操作
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                DialogResult result = MessageBox.Show("确定删除此订单？", "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string orderID = this.dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                    orderBusinessLogic.DeleteOrderById(orderID);//删除已经做级联                 
                    MessageBox.Show("删除成功！");
                    this.dgvOrder.DataSource = orderBusinessLogic.GetOrderByStatus("未提交");
                }
                else
                {
                    MessageBox.Show("删除取消！");
                }
            }
            //单击提交执行的操作
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                //OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
                DialogResult result = MessageBox.Show("确定提交此订单？", "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string orderID = this.dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                    Order order = orderBusinessLogic.GetOrderByID(orderID);
                    order.Status = "未审核";
                    order.InputDate = System.DateTime.Now;
                    orderBusinessLogic.UpdataOrder(order);
                    MessageBox.Show("提交成功！");
                    this.dgvOrder.DataSource = orderBusinessLogic.GetOrderByStatus("未提交");
                }
                else
                {
                    MessageBox.Show("提交取消！");
                }
            }
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {

        }

        //点击待审核列表的查看执行的操作
        private void dgvSubmitOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string orderID = this.dgvSubmitOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                OrderEditForm orderEditForm = new OrderEditForm(orderID, user);
                orderEditForm.Show();
            }
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddOrder_Click(object sender, EventArgs e)
        {

        }

        private void dgvPassOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string orderID = this.dgvPassOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                OrderEditForm orderEditForm = new OrderEditForm(orderID, user);
                orderEditForm.Show();
            }
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string MenuName = txbMenuName.Text.Trim();
        //    View_MenuProvider_RBusinessLogic view_MenuProvider_RBusinessLogic = new View_MenuProvider_RBusinessLogic();
        //    List<View_MenuProvider_R> view_MenuProvider_RList = view_MenuProvider_RBusinessLogic.GetView_MenuProvider_RByName(MenuName);
        //    dgvMenuProvider_R.DataSource = view_MenuProvider_RList;
        //}

        private void dgvNoPassOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string orderID = this.dgvNoPassOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                OrderEditForm orderEditForm = new OrderEditForm(orderID, user);
                orderEditForm.Show();
            }
        }
    }
}

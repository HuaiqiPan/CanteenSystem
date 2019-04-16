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

namespace CanteenSystem.Purchase
{
    public partial class OrderCheckForm : Form
    {
        MORBusinessLogic mORBusinessLogic;
        MenuBusinessLogic menuBusinessLogic;
        OrderBusinessLogic orderBusinessLogic;
        View_MenuBusinessLogic view_MenuBusinessLogic;
        Order order;
        Users user;
        List<MenuOrder_R> menu_Order_RList;
        List<View_Menu> view_MenuList=new List<View_Menu>();
        public OrderCheckForm(string orderID,Users user)
        {
            this.orderBusinessLogic = new OrderBusinessLogic();
            this.mORBusinessLogic = new MORBusinessLogic();
            this.menuBusinessLogic = new MenuBusinessLogic();
            this.view_MenuBusinessLogic = new View_MenuBusinessLogic();
            InitializeComponent();
            this.user = user;
            order = this.orderBusinessLogic.GetOrderByID(orderID);
            txbGroup.Text = order.Department;
            txbCreator.Text = order.Creator;
            txbStatus.Text = order.Status;
            dtpOrderTime.Text = order.InputDate.ToString();
            txbRemark.Text = order.Remark;
            view_MenuList = this.view_MenuBusinessLogic.GetView_MenuByOrderID(orderID);
            menu_Order_RList = this.mORBusinessLogic.GetMORByOrderID(orderID);
            dgvOrderEdit.DataSource = view_MenuList;
            setColumn();

        }

        public void setColumn()
        {
            //查看页面将保存按钮和提交按钮设为不可见
            if (order.Status == "审核通过")
            {
                btnNoPass.Visible = false;
                btnPass.Visible = false;
            }
           
            dgvOrderEdit.Columns[0].Visible = false;
            dgvOrderEdit.Columns[1].Visible = false;
            dgvOrderEdit.Columns[2].Visible = false;
            dgvOrderEdit.Columns[3].HeaderText = "菜名";
            dgvOrderEdit.Columns[4].HeaderCell.Value = "单位";
            dgvOrderEdit.Columns[5].HeaderCell.Value = "数量";
            dgvOrderEdit.Columns[6].HeaderText = "价格";
            dgvOrderEdit.Columns[7].HeaderText = "供应商";
            dgvOrderEdit.Columns[8].HeaderCell.Value = "备注";
            dgvOrderEdit.Columns[3].ReadOnly = true;
            dgvOrderEdit.Columns[4].ReadOnly = true;
        }

        private void dgvOrderEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //通过按钮
        private void btnPass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定通过此订单？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                order.Status = "审核通过";
                order.Verifier = user.RealName;
                this.orderBusinessLogic.UpdataOrder(order);
                MessageBox.Show("审核成功！");
                this.Close();
            }
                
        }
        //不通过按钮
        private void btnNoPass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定不通过此订单？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string reason = txbRemark.Text.Trim();
                if (reason=="")
                {
                    MessageBox.Show("请填写不通过理由！");
                    return;
                }
                else
                {
                    order.Status = "不通过";
                    order.Verifier = user.RealName;
                    order.Remark = txbRemark.Text.Trim();
                    this.orderBusinessLogic.UpdataOrder(order);
                    MessageBox.Show("审核完成！");
                    this.Close();
                }
                
            }
        }
    }
}

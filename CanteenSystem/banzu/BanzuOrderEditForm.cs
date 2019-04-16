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

namespace CanteenSystem.banzu
{
    public partial class BanzuOrderEditForm : Form
    {
        MORBusinessLogic mORBusinessLogic;
        OrderBusinessLogic orderBusinessLogic;
        Order order;
        Users user;
        List<MenuOrder_R> menuOrder_RList;
        public BanzuOrderEditForm(string orderID, Users user)
        {
            this.orderBusinessLogic = new OrderBusinessLogic();
            this.mORBusinessLogic = new MORBusinessLogic();
            InitializeComponent();
            this.user = user;
            order = this.orderBusinessLogic.GetOrderByID(orderID);
            txbGroup.Text = order.Department;
            txbCreator.Text = order.Creator;
            txbStatus.Text = order.Status;
            dtpOrderTime.Text = order.InputDate.ToString();
            txbRemark.Text = order.Remark;
            menuOrder_RList = this.mORBusinessLogic.GetMORByOrderID(orderID);
            dgvOrderEdit.DataSource = menuOrder_RList;
            setColumn();
        }

        public void setColumn()
        {
            dgvOrderEdit.Columns[0].Visible = false;
            dgvOrderEdit.Columns[1].Visible = false;
            dgvOrderEdit.Columns[2].HeaderText = "菜名";
            dgvOrderEdit.Columns[3].HeaderCell.Value = "单位";
            dgvOrderEdit.Columns[4].HeaderCell.Value = "报价";
            dgvOrderEdit.Columns[5].HeaderText = "优惠率";
            dgvOrderEdit.Columns[6].HeaderText = "价格";
            dgvOrderEdit.Columns[7].HeaderText = "数量";
            dgvOrderEdit.Columns[8].HeaderText = "金额";
            dgvOrderEdit.Columns[9].Visible = false;
            dgvOrderEdit.Columns[10].Visible = false;
        }
    }
}

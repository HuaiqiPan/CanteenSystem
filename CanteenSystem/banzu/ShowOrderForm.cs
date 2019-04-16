using CanteenSystem.BusinessLogic;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenSystem.banzu
{
    public partial class ShowOrderForm : Form
    {
        MCORBusinessLogic mCORBusinessLogic;
        CheckedOrderBusinessLogic checkedOrderBusinessLogic;
        CheckedOrder checkedOrder;
        Users user;
        List<MenuCheckedOrder_R> menuCheckedOrder_R;
        public ShowOrderForm(string orderID, Users user)
        {
            this.checkedOrderBusinessLogic = new CheckedOrderBusinessLogic();
            this.mCORBusinessLogic = new MCORBusinessLogic();
            InitializeComponent();
            this.user = user;
            checkedOrder = this.checkedOrderBusinessLogic.GetOrderByID(orderID);
            txbDepartment.Text = checkedOrder.Department;
            txbCreator.Text = checkedOrder.Creator;
            label10.Text= checkedOrder.Status;
            txbProvider.Text = checkedOrder.Provider;
            dtpInputDate.Text = checkedOrder.InputDate.ToString();
            txbTotalMoney.Text = checkedOrder.TotalMoney.ToString();
            textBox1.Text = checkedOrder.Remark;
            menuCheckedOrder_R = this.mCORBusinessLogic.GetMCORByCheckedOrderID(orderID);
            dgvOrderShow.DataSource = menuCheckedOrder_R;
            setColumn();
        }

        public void setColumn()
        {
            dgvOrderShow.Columns[0].Visible = false;
            dgvOrderShow.Columns[1].Visible = false;
            dgvOrderShow.Columns[2].HeaderText = "菜名";
            dgvOrderShow.Columns[3].HeaderCell.Value = "单位";
            dgvOrderShow.Columns[4].HeaderCell.Value = "报价";
            dgvOrderShow.Columns[5].HeaderText = "优惠率";
            dgvOrderShow.Columns[6].HeaderText = "价格";
            dgvOrderShow.Columns[7].HeaderText = "数量";
            dgvOrderShow.Columns[8].HeaderText = "金额";
            dgvOrderShow.Columns[9].Visible = false;
            dgvOrderShow.Columns[10].Visible = false;
        }
    }
}

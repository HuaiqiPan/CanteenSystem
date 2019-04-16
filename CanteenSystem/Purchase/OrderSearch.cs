using CanteenSystem.banzu;
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
    public partial class OrderSearch : Form
    {
        UserBusinessLogic usersBusinessLogic = new UserBusinessLogic();
        Users user = new Users();
        public OrderSearch(string userID)
        {
            InitializeComponent();
            user = usersBusinessLogic.GetUserByID(userID);
            loadOrderList();
            SetdgvOrderListColumns();
        }

        public void SetdgvOrderListColumns()
        {
            dgvOrderList.Columns[0].Visible = false;
            dgvOrderList.Columns[1].HeaderText = "订单号";
            //dgvOrderList.Columns[1].Width = 140;
            dgvOrderList.Columns[2].HeaderText = "部门";
            dgvOrderList.Columns[3].HeaderText = "下单人";
            dgvOrderList.Columns[4].HeaderText = "订单日期";
            //dgvOrderList.Columns[4].Width = 150;
            dgvOrderList.Columns[5].HeaderText = "金额";
            dgvOrderList.Columns[6].HeaderText = "状态";
            dgvOrderList.Columns[7].HeaderText = "审核人";
            dgvOrderList.Columns[8].HeaderText = "审核日期";
            //dgvOrderList.Columns[8].Width = 150;
            dgvOrderList.Columns[9].HeaderText = "供应商";
            //dgvOrderList.Columns[9].Width = 170;
            dgvOrderList.Columns[10].HeaderText = "备注";
            DataGridViewLinkColumn lookLinkColumn = new DataGridViewLinkColumn();
            lookLinkColumn.Text = "查看";
            lookLinkColumn.UseColumnTextForLinkValue = true;
            dgvOrderList.Columns.Insert(11, lookLinkColumn);
        }
        public void loadOrderList()
        {
            CheckedOrderBusinessLogic checkedOrderBusinessLogic = new CheckedOrderBusinessLogic();
            List<CheckedOrder> orderlist = checkedOrderBusinessLogic.GetAllOrder();
            dgvOrderList.DataSource = orderlist;
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CheckedOrderBusinessLogic checkedOrderBusinessLogic = new CheckedOrderBusinessLogic();
            //ColumnIndex == 0是查看一列
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string orderID = this.dgvOrderList.Rows[e.RowIndex].Cells[1].Value.ToString();//id在cells[1]这一列
                //ShowOrderForm showOrderForm = new ShowOrderForm(orderID, user);
                CheckedOrderReportForm checkedOrderReportForm = new CheckedOrderReportForm(orderID, user);
                checkedOrderReportForm.ShowDialog();
                //this.dgvOrderList.DataSource = checkedOrderBusinessLogic.GetAllOrder();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string department = txbdepartment.Text.Trim();
            string provider = txbprovider.Text.Trim();
            string startDate = txbDate1.Text.Trim();
            string endDate = txbDate2.Text.Trim();
            double money, totalMoney = 0;
            CheckedOrderBusinessLogic checkedOrderBusinessLogic = new CheckedOrderBusinessLogic();
            List<CheckedOrder> orderlist = new List<CheckedOrder>();
            if (startDate == "" && endDate == "")
            {
                orderlist = checkedOrderBusinessLogic.GetListByPD(provider, department);
            }
            if (startDate != "" && endDate != "")
            {
                orderlist = checkedOrderBusinessLogic.GetListByPD(provider, department, startDate, endDate);
            }
            if (startDate != "" && endDate == "")
            {
                orderlist = checkedOrderBusinessLogic.GetListByStartDate(provider, department, startDate);
            }
            if (startDate == "" && endDate != "")
            {
                orderlist = checkedOrderBusinessLogic.GetListByEndDate(provider, department, endDate);
            }
            dgvOrderList.DataSource = orderlist;
            for (int i = 0; i < dgvOrderList.Rows.Count; i++)
            {
                if (dgvOrderList.Rows[i].Cells[6].Value != null)
                {
                    money = Convert.ToDouble(dgvOrderList.Rows[i].Cells[6].Value);
                    totalMoney += money;
                }
            }
            label6.Text=totalMoney.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txbDate1.Text = dateTimePicker1.Value.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txbDate2.Text = dateTimePicker2.Value.ToString();
        }

        private void txbDate1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                txbDate1.Text = "";
            }
        }

        private void txbDate2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                txbDate2.Text = "";
            }
        }
    }
}

using CanteenSystem.BusinessLogic;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CanteenSystem.banzu
{
    public partial class CheckFrom : Form
    {
        public int cellRowIndex;
        Users user;
        DataTable dt;
        string orderID=string.Empty;
        public CheckFrom()
        {
            InitializeComponent();
        }
        public CheckFrom(string orderID, Users user)
        {
            MORBusinessLogic mORBusinessLogic = new MORBusinessLogic();
            OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
            InitializeComponent();
            this.orderID = orderID;
            this.user = user;
            Order order = orderBusinessLogic.GetOrderByID(orderID);
            txbOrderId.Text = order.OrderNumber;
            txbDepartment.Text = order.Department;
            txbCreator.Text = order.Creator;
            txbStatus.Text = order.Status;
            txbProvider.Text = order.Provider;
            dtpOrderTime.Text = order.InputDate.ToString();
            label7.Text = order.TotalMoney.ToString();
            this.dt = mORBusinessLogic.GetMOR(orderID);
            dgvOrderCheck.DataSource = this.dt;
            if (user.Remark=="班组")
            {
                btnSubmit.Visible = false;
            }
            setColumn();
        }
       
        public void setColumn()
        {
            dgvOrderCheck.Columns[0].Visible = false;//menuorderID
            dgvOrderCheck.Columns[1].Visible = false;//orderID
            dgvOrderCheck.Columns[2].HeaderText = "菜名";
            dgvOrderCheck.Columns[3].HeaderCell.Value = "单位";
            dgvOrderCheck.Columns[4].HeaderCell.Value = "报价";
            dgvOrderCheck.Columns[5].HeaderText = "优惠率";
            dgvOrderCheck.Columns[6].HeaderText = "价格";
            dgvOrderCheck.Columns[7].HeaderText = "数量";
            dgvOrderCheck.Columns[8].HeaderText = "金额";
            DataGridViewLinkColumn lookLinkColumn = new DataGridViewLinkColumn();
            lookLinkColumn.HeaderText = "操作";
            lookLinkColumn.Text = "删除";
            lookLinkColumn.UseColumnTextForLinkValue = true;
            dgvOrderCheck.Columns.Insert(9, lookLinkColumn);
            dgvOrderCheck.Columns[3].ReadOnly = true;
            dgvOrderCheck.Columns[4].ReadOnly = true;
            dgvOrderCheck.Columns[5].ReadOnly = true;
            dgvOrderCheck.Columns[6].ReadOnly = true;
            dgvOrderCheck.Columns[8].ReadOnly = true;
            listBox1.Visible = false;

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定验收后此订单不可更改！\n是否确定？", "提示！", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
                CheckedOrderBusinessLogic checkedOrderBusinessLogic = new CheckedOrderBusinessLogic();
                MCORBusinessLogic mCORBusinessLogic = new MCORBusinessLogic();
                CheckedOrder checkedOrder = new CheckedOrder();//验收单
                Order order = orderBusinessLogic.GetOrderByID(orderID);
                checkedOrder.CheckedOrderID = order.OrderID;
                checkedOrder.OrderNumber = order.OrderNumber;
                checkedOrder.Provider = order.Provider;
                checkedOrder.Status = "已验收";
                checkedOrder.VeriDate = order.VeriDate;
                checkedOrder.Verifier = order.Verifier;
                checkedOrder.Remark = textBox1.Text.Trim();
                checkedOrder.Department = order.Department;
                checkedOrder.Creator = order.Creator;
                checkedOrder.TotalMoney = Convert.ToDouble(label7.Text);
                checkedOrder.InputDate = order.InputDate;
                order.Status = "已验收";
                bool flag1, flag2;
                try
                {
                    flag1=checkedOrderBusinessLogic.AddOrder(checkedOrder);
                    flag2=orderBusinessLogic.UpdataOrder(order);
                }
                catch (Exception)
                {
                    throw;
                }
                if (flag1&&flag2)
                {
                    int count = dgvOrderCheck.Rows.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (dgvOrderCheck.Rows[i].Cells[3].Value != null && dgvOrderCheck.Rows[i].Cells[8].Value != null)
                        {
                            MenuCheckedOrder_R MCOR = new MenuCheckedOrder_R();
                            MCOR.MenuCheckedOrderID = Guid.NewGuid().ToString();
                            MCOR.CheckedOrderID = order.OrderID;
                            MCOR.MenuName = dgvOrderCheck.Rows[i].Cells[3].Value.ToString();
                            MCOR.Unit = dgvOrderCheck.Rows[i].Cells[4].Value.ToString();
                            MCOR.Quote = Convert.ToDouble(dgvOrderCheck.Rows[i].Cells[5].Value);
                            MCOR.Rate = Convert.ToDouble(dgvOrderCheck.Rows[i].Cells[6].Value);
                            MCOR.Price = Convert.ToDouble(dgvOrderCheck.Rows[i].Cells[7].Value);
                            MCOR.Count = Convert.ToDouble(dgvOrderCheck.Rows[i].Cells[8].Value);
                            MCOR.Money = Convert.ToDouble(dgvOrderCheck.Rows[i].Cells[9].Value);
                            MCOR.InputDate = order.InputDate;
                            //MOR.Remark = null;
                            mCORBusinessLogic.AddMCOR(MCOR);
                        }
                    }
                    MessageBox.Show("您已成功保存验收单！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }
        }

        private void dgvOrderCheck_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
     
        }

        private void dgvOrderCheck_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cellRowIndex = e.RowIndex;
            MenuBusinessLogic menuBusinessLogic = new MenuBusinessLogic();
            List<string> menus = new List<string>();
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                if (dgvOrderCheck.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    string menuname = dgvOrderCheck.Rows[e.RowIndex].Cells[3].Value.ToString();
                    menus = menuBusinessLogic.GetMenusByMenuName(menuname);
                    this.listBox1.DataSource = menus;
                    listBox1.Visible = true;
                }
                else
                {
                    return;
                }

            }
            //输入菜品数量后自动求出金额
            if (e.ColumnIndex == 8&& e.RowIndex != -1)
            {
                double count = Convert.ToDouble(dgvOrderCheck.Rows[cellRowIndex].Cells[8].Value);
                double price = Convert.ToDouble(dgvOrderCheck.Rows[cellRowIndex].Cells[7].Value);
                double money = count * price;
                dgvOrderCheck.Rows[cellRowIndex].Cells[9].Value = money;
                computertotalMoney();
            }
        }
        //计算总金额方法
        public void computertotalMoney()
        {
            double money;
            double totalMoney = 0;
            for (int i = 0; i < dgvOrderCheck.Rows.Count; i++)
            {
                if (dgvOrderCheck.Rows[i].Cells[9].Value != null)
                {
                    money = Convert.ToDouble(dgvOrderCheck.Rows[i].Cells[9].Value);
                    totalMoney += money;
                }
            }
            label7.Text = totalMoney.ToString();//合计总金额
        }
        private void dgvOrderCheck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //操作一列在columns[0]
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                dt.Rows[e.RowIndex].Delete();
                dgvOrderCheck.DataSource = this.dt;
                computertotalMoney();
            }
        }

        private void dgvOrderCheck_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            {
                double count = Convert.ToDouble(dgvOrderCheck.Rows[e.RowIndex].Cells[8].Value);
                double price = Convert.ToDouble(dgvOrderCheck.Rows[e.RowIndex].Cells[7].Value);
                double money = count * price;
                dgvOrderCheck.Rows[e.RowIndex].Cells[9].Value = money;
                computertotalMoney();
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            MenuBusinessLogic menuBusinessLogic = new MenuBusinessLogic();
            int index = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
                string menuname = listBox1.SelectedItem.ToString();
                Model.Menu menu = menuBusinessLogic.GetMenuByName(menuname);
                dgvOrderCheck.Rows[cellRowIndex].Cells[3].Value = menuname;
                dgvOrderCheck.Rows[cellRowIndex].Cells[4].Value = menu.Unit;
                dgvOrderCheck.Rows[cellRowIndex].Cells[5].Value = menu.MenuQuote;
                dgvOrderCheck.Rows[cellRowIndex].Cells[6].Value = menu.MenuRate;
                dgvOrderCheck.Rows[cellRowIndex].Cells[7].Value = menu.MenuPrice;
            }
            if (dgvOrderCheck.Rows[cellRowIndex].Cells[8].Value != null&& dgvOrderCheck.Rows[cellRowIndex].Cells[8].Value.ToString()!="")
            {
                string a = dgvOrderCheck.Rows[cellRowIndex].Cells[8].Value.ToString();
                Console.Write(dgvOrderCheck.Rows[cellRowIndex].Cells[8].Value);
                double count = Convert.ToDouble(dgvOrderCheck.Rows[cellRowIndex].Cells[8].Value);
                double price = Convert.ToDouble(dgvOrderCheck.Rows[cellRowIndex].Cells[7].Value);
                double money = count * price;
                dgvOrderCheck.Rows[cellRowIndex].Cells[9].Value = money;
                computertotalMoney();
            }
            this.listBox1.DataSource = null;
            listBox1.Visible = false;
        }
    }
}

using CanteenSystem.BusinessLogic;
using CanteenSystem.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CanteenSystem.banzu
{
    public partial class BanzuOrderListForm2 : Form
    {
        UserBusinessLogic usersBusinessLogic = new UserBusinessLogic();
        Users user = new Users();
        public BanzuOrderListForm2(string userID)
        {
            user = usersBusinessLogic.GetUserByID(userID);
            InitializeComponent();
            loadOrderList();
            setColumn();
        }

        public void loadOrderList()
        {
            OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
            List<Order> orderlist = orderBusinessLogic.GetOrderByStatusAndCreator("已验收", user.RealName);
            dataGridView1.DataSource = orderlist;
        }

        public void setColumn()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "订单号";
            //dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].HeaderText = "部门";
            dataGridView1.Columns[3].HeaderText = "下单人";
            dataGridView1.Columns[4].HeaderText = "订单日期";
            //dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].HeaderText = "金额";
            dataGridView1.Columns[6].HeaderText = "状态";
            dataGridView1.Columns[7].HeaderText = "审核人";
            dataGridView1.Columns[8].HeaderText = "审核日期";
            //dataGridView1.Columns[8].Width = 150;
            dataGridView1.Columns[9].HeaderText = "供应商";
            //dataGridView1.Columns[9].Width = 170;
            dataGridView1.Columns[10].HeaderText = "备注";
            DataGridViewLinkColumn lookLinkColumn = new DataGridViewLinkColumn();
            lookLinkColumn.Text = "查看";
            lookLinkColumn.UseColumnTextForLinkValue = true;
            dataGridView1.Columns.Insert(11, lookLinkColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
            //ColumnIndex == 0是查看一列
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string orderID = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//id在cells[1]这一列
                //OrderEditForm orderEditForm = new OrderEditForm(orderID, user);
                //orderEditForm.ShowDialog();
                OrderReportForm orderReportForm = new OrderReportForm(orderID, user);
                orderReportForm.ShowDialog();
                this.dataGridView1.DataSource = orderBusinessLogic.GetOrderByStatus("已验收");
            }
        }
    }
}

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
    public partial class ApplyForm_Form : Form
    {
        public int cellRowIndex;
        View_GroupBusinessLogic view_GroupBusinessLogic = new View_GroupBusinessLogic();
        UserBusinessLogic usersBusinessLogic = new UserBusinessLogic();
        Users user = new Users();
        Group group = new Group();
        View_Group view_Group = new View_Group();
        public ApplyForm_Form()
        {
            InitializeComponent();
            dgvload();
        }

        public ApplyForm_Form(string userID)
        {
            InitializeComponent();
            dgvload();
            user = usersBusinessLogic.GetUserByID(userID);
            view_Group = view_GroupBusinessLogic.GetView_GroupByUserID(userID);
            txbDepartment.Text = view_Group.GroupName;
            txbCreater.Text = user.RealName;
            txbOrderDate.Text = DateTime.Now.ToString();
            txbOrderNumber.Text = "PQ-" + DateTime.Now.ToString("yyyy-MM-dd-HHmmss");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ApplyForm_Form_Load(object sender, EventArgs e)
        {

        }

       /// <summary>
       /// 初始化datagridview 10行
       /// </summary>
        private void dgvload()
        {
            //this.dataGridView1.Columns[0].HeaderCell.Value = "序号";
            for (int i = 0; i < 1; i++)
            {
                this.dataGridView1.Rows.Add();
            }
            listBox1.Visible = false;
        }
        /// <summary>
        /// 每行的行头标上序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //显示在HeaderCell上
            int count = this.dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataGridViewRow r = this.dataGridView1.Rows[i];
                r.HeaderCell.Value = string.Format("{0}", i + 1);
            }
            DataGridViewRow endrow = this.dataGridView1.Rows[count-1];
            endrow.HeaderCell.Value = "合计";
            this.dataGridView1.Refresh();
        }

        //单元格编辑完成事件，用于输入菜品后同时将菜品各种属性一起填写
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cellRowIndex = e.RowIndex;
            MenuBusinessLogic menuBusinessLogic = new MenuBusinessLogic();
            List<string> menus = new List<string>();
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string menuname = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    menus = menuBusinessLogic.GetMenusByMenuName(menuname);
                    this.listBox1.DataSource = menus;
                    listBox1.Visible = true;
                }else
                {
                    return;
                }                
            }
            //输入菜品数量后自动求出金额
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                double totalMoney = 0;
                double count=Convert.ToDouble(dataGridView1.Rows[cellRowIndex].Cells[3].Value);
                double price=Convert.ToDouble(dataGridView1.Rows[cellRowIndex].Cells[6].Value);
                double money = count * price;
                dataGridView1.Rows[cellRowIndex].Cells[7].Value = money;
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[7].Value != null)
                    {
                        money = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                        totalMoney += money;
                    }
                }
                this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[7].Value = totalMoney.ToString();
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
                dataGridView1.Rows[cellRowIndex].Cells[0].Value = menuname;
                dataGridView1.Rows[cellRowIndex].Cells[2].Value = menu.Unit;
                dataGridView1.Rows[cellRowIndex].Cells[4].Value = menu.MenuQuote;
                dataGridView1.Rows[cellRowIndex].Cells[5].Value = menu.MenuRate;
                dataGridView1.Rows[cellRowIndex].Cells[6].Value = menu.MenuPrice;
            }
            if (dataGridView1.Rows[cellRowIndex].Cells[3].Value!=null)
            {
                double totalMoney = 0;
                double count = Convert.ToDouble(dataGridView1.Rows[cellRowIndex].Cells[3].Value);
                double price = Convert.ToDouble(dataGridView1.Rows[cellRowIndex].Cells[6].Value);
                double money = count * price;
                dataGridView1.Rows[cellRowIndex].Cells[7].Value = money;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[7].Value != null)
                    {
                        money = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                        totalMoney += money;
                    }
                }
                this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[7].Value = totalMoney.ToString();
            }
            this.listBox1.DataSource = null;
            listBox1.Visible = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //先判断单元格内容是否为空，如果不为空则先减去原来的金额数再加上修改后的金额数
            
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            MenuBusinessLogic menuBusinessLogic = new MenuBusinessLogic();
            OrderBusinessLogic orderBusinessLogic = new OrderBusinessLogic();
            MORBusinessLogic mORBusinessLogic = new MORBusinessLogic();
            Order order = new Order();
            bool flag = orderBusinessLogic.IscontainOrder(txbOrderNumber.Text.Trim());
            if (flag)
            {
                MessageBox.Show("订单已存在！", "提示");
                return;
            }
            if (dataGridView1.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("订单不能为空！", "提示");
                return;
            }
            if (dataGridView1.Rows[cellRowIndex].Cells[0].Value != null&&dataGridView1.Rows[cellRowIndex].Cells[3].Value==null)
            {
                MessageBox.Show("数量不能为空！", "提示");
                return;
            }
            if (dataGridView1.Rows[cellRowIndex].Cells[0].Value == null && dataGridView1.Rows[cellRowIndex].Cells[3].Value != null)
            {
                MessageBox.Show("请填写菜品！", "提示");
                return;
            }
            order.OrderID = Guid.NewGuid().ToString();
            order.OrderNumber = txbOrderNumber.Text.Trim();
            order.Department = txbDepartment.Text.Trim();
            order.Creator = txbCreater.Text.Trim();
            order.InputDate = Convert.ToDateTime(txbOrderDate.Text.Trim());
            order.TotalMoney = Convert.ToDouble(this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[7].Value);
            order.Status = "未发送";
            orderBusinessLogic.AddOrder(order);
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count-1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null&& dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    string menuName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Model.Menu menu = menuBusinessLogic.GetMenuByName(menuName);
                    MenuOrder_R MOR = new MenuOrder_R();
                    MOR.MenuOrderID = Guid.NewGuid().ToString();
                    MOR.OrderID = order.OrderID;
                    MOR.MenuName = menu.MenuName;
                    MOR.Unit = menu.Unit;
                    MOR.InputDate = Convert.ToDateTime(txbOrderDate.Text.Trim());
                    MOR.Money = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                    MOR.Quote = menu.MenuQuote;
                    MOR.Rate = menu.MenuRate;
                    MOR.Price = menu.MenuPrice;
                    MOR.Count = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    //MOR.Remark = null;
                    mORBusinessLogic.AddMOR(MOR); 
                }
            }
            MessageBox.Show("提交成功！", "提示");
        }
    }
}

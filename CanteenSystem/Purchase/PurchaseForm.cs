using CanteenSystem.BusinessLogic;
using CanteenSystem.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenSystem.Purchase
{
    public partial class PurchaseForm : Form
    {
        
        List<string> deleteMenuIDList = new List<string>();
       
        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“canteenDBDataSet.Provider”中。您可以根据需要移动或删除它。
            //this.providerTableAdapter.Fill(this.canteenDBDataSet.Provider);

        }
        public PurchaseForm()
        {
            InitializeComponent();
            loadMenu();
            setColumn();
        }

        private void loadMenu()
        {
            MenuBusinessLogic menuBusinessLogic = new MenuBusinessLogic();
            List<Model.Menu> menuList = new List<Model.Menu>();
            menuList = menuBusinessLogic.GetAllMenu();
            dgvPlan.DataSource = menuList;
        }
        public void setColumn()
        {
            //btnDelete.Visible = false;//删除某菜品时，该菜品在订单上的也会同时被删除，所以菜品应该不能删除
            DataGridViewCheckBoxColumn dgvcheckboxColumn = new DataGridViewCheckBoxColumn();
            dgvcheckboxColumn.HeaderText = "选择";
            dgvcheckboxColumn.Name = "cb_check";
            dgvPlan.Columns.Insert(0, dgvcheckboxColumn);
            dgvPlan.Columns[0].Width = 50;
            DataGridViewButtonColumn dgvbtnColumn = new DataGridViewButtonColumn();
            dgvbtnColumn.HeaderText = "编辑";
            dgvbtnColumn.Name = "btn_Edit";
            dgvbtnColumn.Text = "编辑";
            dgvbtnColumn.UseColumnTextForButtonValue = true;
            dgvPlan.Columns.Insert(1, dgvbtnColumn);
            dgvPlan.Columns[2].Visible = false;
            dgvPlan.Columns[3].HeaderCell.Value = "菜名";
            dgvPlan.Columns[4].HeaderCell.Value = "单位";
            dgvPlan.Columns[5].HeaderCell.Value = "报价";
            dgvPlan.Columns[6].HeaderCell.Value = "优惠率";
            dgvPlan.Columns[7].HeaderCell.Value = "单价";
            dgvPlan.Columns[8].HeaderCell.Value = "日期";
            dgvPlan.Columns[9].HeaderCell.Value = "备注";
            dgvPlan.Columns[3].ReadOnly = true;
            dgvPlan.Columns[4].ReadOnly = true;
            dgvPlan.Columns[5].ReadOnly = true;
            dgvPlan.Columns[6].ReadOnly = true;
            dgvPlan.Columns[7].ReadOnly = true;
            dgvPlan.Columns[8].ReadOnly = true;
            dgvPlan.Columns[9].ReadOnly = true;
        }

        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            MenuBusinessLogic menuBusinessLogic = new MenuBusinessLogic();
            PriceBusinessLogic priceBusinessLogic = new PriceBusinessLogic();
            Model.Menu menu = new Model.Menu();
            menu.MenuID = Guid.NewGuid().ToString();
            if (txbMenuName.Text.Trim()!= "")
            {
                menu.MenuName = txbMenuName.Text.Trim();
                if (menuBusinessLogic.GetMenuByName(menu.MenuName) != null)
                {
                    MessageBox.Show("该菜品已存在，不能重复添加！");
                    return;
                }     
            }
            else
            {
                MessageBox.Show("菜品名称不能为空!");
                return;
            }
            
            if (txbUint.Text.Trim()== "")
            {
                MessageBox.Show("菜品单价不能为空!");
                return;
            }
            else
            {
                menu.Unit = txbUint.Text.Trim();
            }
            double Quote = 0;
            if (!double.TryParse(txbQuote.Text.Trim(), out Quote))
            {
                MessageBox.Show("报价处请输入数字!");
                return;
            }
            menu.MenuQuote = Quote;
            double Rate = 1.0;
            if (!double.TryParse(txbRate.Text.Trim(), out Rate))
            {
                MessageBox.Show("请输入优惠率!");
                return;
            }
            menu.MenuRate = Rate;
            menu.MenuPrice = Quote*Rate;
            menu.InputDate = DateTime.Now;

            Price price = new Price();
            price.PriceID= Guid.NewGuid().ToString();
            price.MenuID = menu.MenuID;
            price.Quote = Quote;
            price.Rate = Rate;
            price.Price1 = Quote * Rate;
            price.InputDate = Convert.ToDateTime(menu.InputDate);
            if (menuBusinessLogic.AddMenu(menu)&& priceBusinessLogic.AddPrice(price))
            {
                MessageBox.Show("添加成功！");
                txbMenuName.Clear();
                txbUint.Clear();
                txbQuote.Clear();
                txbRate.Clear();
                loadMenu();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //删除
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dgvPlan.Rows[e.RowIndex].Cells[0]);
                string KeyID = this.dgvPlan.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                {
                    deleteMenuIDList.Add(KeyID);
                }
                else
                {
                    deleteMenuIDList.Remove(KeyID);
                }
            }
            //编辑
            else if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                Console.Write(e.ColumnIndex);
                Console.Write(e.RowIndex);
                string MenuID = this.dgvPlan.Rows[e.RowIndex].Cells[2].Value.ToString();
                UpdataMenuForm updataMenuForm = new UpdataMenuForm(MenuID);
                updataMenuForm.ShowDialog();
                loadMenu();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MenuBusinessLogic menuBusinessLogic = new MenuBusinessLogic();
            bool flag = false;
            if (deleteMenuIDList.Count == 0)
            {
                MessageBox.Show("请选择要删除的菜品！");
            }
            else
            {
                foreach (string MenuID in deleteMenuIDList)
                {
                    flag = menuBusinessLogic.DeleteMenuByMenuID(MenuID);
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
            deleteMenuIDList.Clear();
            loadMenu();    
        }
    }
}

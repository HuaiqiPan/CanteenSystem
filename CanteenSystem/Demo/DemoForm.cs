using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanteenSystem.BusinessLogic;
using CanteenSystem.Model;

namespace CanteenSystem
{
    public partial class DemoForm : Form
    {
        List<string> deleteKeyIDList = new List<string>();
        public string UpdateKeyID = string.Empty;
        //bool isUpdate = false;

        public DemoForm()
        {
            InitializeComponent();
            loadAllCantenOrderData();
            setColumns();
            BuildComboboxItems();
        }

        private void BuildComboboxItems()
        {
            cbxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            //构造数据源（或从数据库中查询）  
            DataTable dt = new DataTable();
            DataColumn ADC1 = new DataColumn("KEY", typeof(string));
            DataColumn ADC2 = new DataColumn("VALUE", typeof(string));
            dt.Columns.Add(ADC1);
            dt.Columns.Add(ADC2);
            DataRow OrderName = dt.NewRow();
            OrderName[0] = "订单名称";
            OrderName[1] = "CanteenOrderName";
            dt.Rows.Add(OrderName);
            //进行绑定  
            cbxFilter.DisplayMember = "KEY";//控件显示的列名  
            cbxFilter.ValueMember = "VALUE";//控件值的列名  
            cbxFilter.DataSource = dt;
        }

        /// <summary>
        /// 载入所有订单数据
        /// </summary>
        private void loadAllCantenOrderData()
        {
            CanteenOrderBusinessLogic canteenOrderBusinessLogic = new CanteenOrderBusinessLogic();
            List<CanteenOrder> canteenOrderList = canteenOrderBusinessLogic.GetAll();
            dgvCanteenOrder.DataSource = canteenOrderList;
        }

        /// <summary>
        /// 设置列名
        /// </summary>
        private void setColumns()
        {
            DataGridViewCheckBoxColumn dgvcheckboxColumn = new DataGridViewCheckBoxColumn();
            dgvcheckboxColumn.HeaderText = "选择";
            dgvcheckboxColumn.Name = "cb_check";
            dgvCanteenOrder.Columns.Insert(0, dgvcheckboxColumn);
            dgvCanteenOrder.Columns[0].Width = 50;
            DataGridViewButtonColumn dgvbtnColumn = new DataGridViewButtonColumn();
            dgvbtnColumn.HeaderText = "编辑";
            dgvbtnColumn.Name = "btn_Edit";
            dgvbtnColumn.Text = "编辑";
            dgvbtnColumn.UseColumnTextForButtonValue = true;
            dgvCanteenOrder.Columns.Insert(1, dgvbtnColumn);

            dgvCanteenOrder.Columns[2].Visible = false;
            dgvCanteenOrder.Columns[3].HeaderCell.Value = "订单名称";
            dgvCanteenOrder.Columns[4].HeaderCell.Value = "订单价格";
            dgvCanteenOrder.Columns[5].HeaderCell.Value = "订单数量";
            dgvCanteenOrder.Columns[6].HeaderCell.Value = "备注";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CanteenOrderBusinessLogic canteenOrderBusinessLogic = new CanteenOrderBusinessLogic();
            string selectedValue = cbxFilter.SelectedValue.ToString();

            switch (selectedValue)
            {
                case "CanteenOrderName":
                    List<CanteenOrder> canteenOrderList = canteenOrderBusinessLogic.GetCanteenOrderByName(txtSearchText.Text.Trim());
                    dgvCanteenOrder.DataSource = canteenOrderList;
                    break;
                default:
                    loadAllCantenOrderData();break;
            }
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CanteenOrder canteenOrder = new CanteenOrder();
            canteenOrder.CanteenOrderKeyID = Guid.NewGuid().ToString();
            canteenOrder.CanteenOrderName = txtCanteenName.Text.Trim();
            double money = 0;
            if (!double.TryParse(txtCanteenOrderMoney.Text.Trim(), out money))
            {
                MessageBox.Show("订单价格处请输入数字!");
                return;
            }
            canteenOrder.CanteenOrderMoney = money;
            int count = 0;
            if (!int.TryParse(txtCanteenOrderCount.Text.Trim(), out count))
            {
                MessageBox.Show("订单数量处青输入数字!");
                return;
            }
            canteenOrder.CanteenOrderCount = count;

            CanteenOrderBusinessLogic canteenOrderBusinessLogic = new CanteenOrderBusinessLogic();
            if (canteenOrderBusinessLogic.Add(canteenOrder))
            {
                loadAllCantenOrderData();
                MessageBox.Show("添加成功");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            CanteenOrderBusinessLogic canteenOrderBusinessLogic = new CanteenOrderBusinessLogic();
            foreach (string keyid in deleteKeyIDList)
            {
                canteenOrderBusinessLogic.delete(keyid);
            }
            MessageBox.Show("删除成功");
            loadAllCantenOrderData();
        }

        private void dgvCanteenOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvCanteenOrder.CurrentCell.ColumnIndex == 0)
            //{
            //    DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dgvCanteenOrder.Rows[this.dgvCanteenOrder.CurrentCell.RowIndex].Cells[0]);
            //    string KeyID = this.dgvCanteenOrder.Rows[this.dgvCanteenOrder.CurrentCell.RowIndex].Cells[1].Value.ToString();
            //    if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == false)
            //    {
            //        deleteKeyIDList.Add(KeyID);
            //        dgvCheck.Value = true;
            //    }
            //    else
            //    {
            //        deleteKeyIDList.Remove(KeyID);
            //        dgvCheck.Value = false;
            //    }
            //}
        }

        private void dgvCanteenOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //删除
            if(e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dgvCanteenOrder.Rows[e.RowIndex].Cells[0]);
                string KeyID = this.dgvCanteenOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                {
                    deleteKeyIDList.Add(KeyID);
                }
                else
                {
                    deleteKeyIDList.Remove(KeyID);
                }
            }
            else if(e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                string KeyID = this.dgvCanteenOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                UpdateCantenOrderForm updateCanteenOrderForm = new UpdateCantenOrderForm(KeyID);
                updateCanteenOrderForm.ShowDialog();
                loadAllCantenOrderData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //UpdateCantenOrderForm updateCanteenOrderForm = new UpdateCantenOrderForm();
            //updateCanteenOrderForm.ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

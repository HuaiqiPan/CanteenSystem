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

namespace CanteenSystem.Provider
{
    public partial class ProviderManageForm : Form
    {
        public ProviderManageForm()
        {
            InitializeComponent();
            LoadProvider();
            SetColumn();
        }

        private void ProviderManage_Load(object sender, EventArgs e)
        {

        }
        private void LoadProvider()
        {
            ProviderBusinessLogic providerBusinessLogic = new ProviderBusinessLogic();
            dgvProvider.DataSource = providerBusinessLogic.GetAllProvider();
        }
        private void SetColumn()
        {
            dgvProvider.Columns[0].HeaderText = "供应商编号";
            dgvProvider.Columns[1].HeaderText = "供应商名称";
            dgvProvider.Columns[2].HeaderText = "供应商地址";
            //dgvProvider.Columns[2].Width = 170;
            dgvProvider.Columns[3].HeaderText = "供应商电话";
            dgvProvider.Columns[4].HeaderText = "联系人";
            dgvProvider.Columns[5].HeaderText = "创建日期";
            //dgvProvider.Columns[5].Width = 150;
            dgvProvider.Columns[6].HeaderText = "备注";

            DataGridViewLinkColumn editColumn = new DataGridViewLinkColumn();
            editColumn.Text = "编辑";
            editColumn.UseColumnTextForLinkValue = true;
            dgvProvider.Columns.Insert(7, editColumn);
            DataGridViewLinkColumn deleteColumn = new DataGridViewLinkColumn();
            deleteColumn.Text = "删除";
            deleteColumn.UseColumnTextForLinkValue = true;
            dgvProvider.Columns.Insert(8, deleteColumn);

        }

        private void dgvProvider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            Console.WriteLine(e.RowIndex);
            ProviderBusinessLogic providerBusinessLogic = new ProviderBusinessLogic();
            //单击编辑执行的操作
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string providerID = this.dgvProvider.Rows[e.RowIndex].Cells[2].Value.ToString();
                ProviderEditForm providerEditForm = new ProviderEditForm(providerID);
                providerEditForm.ShowDialog();
                this.dgvProvider.DataSource = providerBusinessLogic.GetAllProvider();
            }
            //单击删除执行的操作
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                DialogResult result = MessageBox.Show("确定删除此供应商？", "提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string providerID = this.dgvProvider.Rows[e.RowIndex].Cells[2].Value.ToString();
                    providerBusinessLogic.DeleteProviderByID(providerID);

                    MessageBox.Show("删除成功！");
                    this.dgvProvider.DataSource = providerBusinessLogic.GetAllProvider();
                }
                else
                {
                    MessageBox.Show("删除取消！");
                }
            }
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            ProviderBusinessLogic providerBusinessLogic = new ProviderBusinessLogic();
            AddProviderForm addProviderForm = new AddProviderForm();
            addProviderForm.ShowDialog();
            this.dgvProvider.DataSource = providerBusinessLogic.GetAllProvider();
        }
    }
}
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
    public partial class CheckedOrderReportForm : Form
    {
        Users user;
        string checkedOrderID = "";
        public CheckedOrderReportForm(string checkedOrderID,Users user)
        {
            InitializeComponent();
            this.user = user;
            this.checkedOrderID = checkedOrderID;
            
        }

        private void CheckedOrderReportForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“checkedOrderDataSet.CheckedOrder”中。您可以根据需要移动或删除它。
            //this.CheckedOrderTableAdapter.Fill(this.checkedOrderDataSet.CheckedOrder);
            //string checkedOrderID = "16b9f43c-7a7c-4142-8a36-ebbd5ea1a60a";
            this.CheckedOrderTableAdapter.FillByCheckedOrderID(this.checkedOrderDataSet.CheckedOrder, this.checkedOrderID);
            this.MenuCheckedOrder_RTableAdapter.FillByCheckedOrderID(this.checkedOrderDataSet.MenuCheckedOrder_R, this.checkedOrderID);
            this.reportViewer1.RefreshReport();
        }
    }
}

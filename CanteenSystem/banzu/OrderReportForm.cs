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
    public partial class OrderReportForm : Form
    {
        Users user;
        string orderID = "";
        public OrderReportForm(string orderID, Users user)
        {
            InitializeComponent();
            this.user = user;
            this.orderID = orderID;
        }

        private void OrderReportForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“orderDataSet.Order”中。您可以根据需要移动或删除它。
            this.orderTableAdapter.FillByOrderID(this.orderDataSet.Order,this.orderID);
            // TODO: 这行代码将数据加载到表“orderDataSet.MenuOrder_R”中。您可以根据需要移动或删除它。
            this.menuOrder_RTableAdapter.FillByOrderID(this.orderDataSet.MenuOrder_R,this.orderID);
            this.reportViewer1.RefreshReport();
        }
    }
}

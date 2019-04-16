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
using CanteenSystem.Model;

namespace CanteenSystem
{
    public partial class UpdateCantenOrderForm : Form
    {
        private string CanteenOrderKeyID = string.Empty;

        public UpdateCantenOrderForm(string KeyID)
        {
            InitializeComponent();

            CanteenOrderBusinessLogic canteenOrderBusinessLogic = new CanteenOrderBusinessLogic();
            CanteenOrderKeyID = KeyID;
            CanteenOrder canteenOrder = canteenOrderBusinessLogic.GetCanteenOrderByKeyID(KeyID);
            txtCanteenName.Text = canteenOrder.CanteenOrderName;
            txtCanteenOrderCount.Text = canteenOrder.CanteenOrderCount.ToString();
            txtCanteenOrderMoney.Text = canteenOrder.CanteenOrderMoney.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CanteenOrderBusinessLogic canteenOrderBusinessLogic = new CanteenOrderBusinessLogic();
            CanteenOrder canteenOrder = canteenOrderBusinessLogic.GetCanteenOrderByKeyID(CanteenOrderKeyID);
            canteenOrder.CanteenOrderName = txtCanteenName.Text.Trim();

            double money = 0;
            if (double.TryParse(txtCanteenOrderMoney.Text.Trim(), out money))
            {
                canteenOrder.CanteenOrderMoney = money;
            }
            else
            {
                MessageBox.Show("订单价格处请输入数字!");
                return;
            }

            int OrderCount = 0;
            if (int.TryParse(txtCanteenOrderCount.Text.Trim(), out OrderCount))
            {
                canteenOrder.CanteenOrderCount = OrderCount;
            }
            else
            {
                MessageBox.Show("订单数量处青输入数字!");
                return;
            }

            if (canteenOrderBusinessLogic.Update(canteenOrder))
            {
                MessageBox.Show("修改成功！");
            }
        }

        private void UpdateCantenOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}

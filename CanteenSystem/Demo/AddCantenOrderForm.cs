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
using CanteenSystem.BusinessLogic;

namespace CanteenSystem
{
    public partial class AddCantenOrderForm : Form
    {
        public AddCantenOrderForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CanteenOrder canteenOrder = new CanteenOrder();
            canteenOrder.CanteenOrderKeyID = Guid.NewGuid().ToString();
            canteenOrder.CanteenOrderName = txtCanteenName.Text.Trim();
            double money = 0;
            if(!double.TryParse(txtCanteenOrderMoney.Text.Trim(), out money))
            {
                MessageBox.Show("订单价格处请输入数字!");
                return;
            }
            canteenOrder.CanteenOrderMoney = money;
            int count = 0;
            if(!int.TryParse(txtCanteenOrderCount.Text.Trim(), out count))
            {
                MessageBox.Show("订单数量处青输入数字!");
                return;
            }
            canteenOrder.CanteenOrderCount = count;

            CanteenOrderBusinessLogic canteenOrderBusinessLogic = new CanteenOrderBusinessLogic();
            if(canteenOrderBusinessLogic.Add(canteenOrder))
            {
                MessageBox.Show("添加成功");
            }
        }

        private void AddCantenOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}

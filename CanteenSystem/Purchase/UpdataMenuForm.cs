using CanteenSystem.BusinessLogic;
using CanteenSystem.Model;
using System;
using System.Windows.Forms;

namespace CanteenSystem.Purchase
{
    public partial class UpdataMenuForm : Form
    {
        MenuBusinessLogic menuBusinessLogic;
        Model.Menu menu;
        Model.Provider provider=new Model.Provider();
        PriceBusinessLogic priceBusinessLogic = new PriceBusinessLogic();
        public UpdataMenuForm(string MenuID)
        {
            InitializeComponent();
            menuBusinessLogic = new MenuBusinessLogic();
            menu = menuBusinessLogic.GetMenuByID(MenuID);
            txbMenuName.Text = menu.MenuName;
            txbUint.Text = menu.Unit;
            txbQuote.Text = menu.MenuQuote.ToString();
            txbRate.Text = menu.MenuRate.ToString();
            txbInputDate.Text = menu.InputDate.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbMenuName.Text.Trim() == null)
            {
                MessageBox.Show("菜品名称不能为空!");
            }
            menu.MenuName = txbMenuName.Text.Trim();
            if (txbUint.Text.Trim() == null)
            {
                MessageBox.Show("菜品单价不能为空!");
            }
            menu.Unit = txbUint.Text.Trim();
            double Quote = 0;
            if (!double.TryParse(txbQuote.Text.Trim(), out Quote))
            {
                MessageBox.Show("价格处请输入数字!");
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
            menu.MenuPrice = Quote * Rate;
            menu.InputDate = DateTime.Now;

            Price price = new Price();
            price.PriceID = Guid.NewGuid().ToString();
            price.MenuID = menu.MenuID;
            price.Quote = Quote;
            price.Rate = Rate;
            price.Price1 = Quote * Rate;
            price.InputDate = Convert.ToDateTime(menu.InputDate);
            if (menuBusinessLogic.UpdataMenu(menu)&&priceBusinessLogic.AddPrice(price))
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }

        }
    }
}

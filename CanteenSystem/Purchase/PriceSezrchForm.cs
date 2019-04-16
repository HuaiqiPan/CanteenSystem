using CanteenSystem.BusinessLogic;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CanteenSystem.Purchase
{
    public partial class PriceSezrchForm : Form
    {
        public PriceSezrchForm()
        {
            View_PriceBusinessLogic view_PriceBusinessLogic = new View_PriceBusinessLogic();
            List<View_Price> priceList = new List<View_Price>();
            InitializeComponent();
            priceList = view_PriceBusinessLogic.GetAllPrice();
            this.dataGridView1.DataSource = priceList;
            setColumn();
        }
        public void setColumn()
        {
            dataGridView1.Columns[0].Visible = false;//menuID
            dataGridView1.Columns[1].Visible = false;//priceID
            dataGridView1.Columns[2].HeaderText = "菜名";
            dataGridView1.Columns[3].HeaderCell.Value = "单位";
            dataGridView1.Columns[4].HeaderCell.Value = "报价";
            dataGridView1.Columns[5].HeaderText = "优惠率";
            dataGridView1.Columns[6].HeaderText = "价格";
            dataGridView1.Columns[7].HeaderText = "日期";
            dataGridView1.Columns[7].Width = 200;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string munename = txbMunename.Text.Trim();
            string startDate = txbdate1.Text.Trim();
            string endDate = txbdate2.Text.Trim();
            View_PriceBusinessLogic view_PriceBusinessLogic = new View_PriceBusinessLogic();
            List<View_Price> priceList = new List<View_Price>();
            if (munename!="")
            {
                if (startDate == "" && endDate == "")
                {
                    //startDate != "";
                    priceList = view_PriceBusinessLogic.GetPriceByName(munename);
                }
                if (startDate != "" && endDate != "")
                {
                    //startDate != "";
                    priceList = view_PriceBusinessLogic.GetPriceByName(munename, startDate, endDate);
                }
                if (startDate != "" && endDate == "")
                {
                    priceList = view_PriceBusinessLogic.GetPriceByStartDate(munename, startDate);
                }
                if (startDate == "" && endDate != "")
                {
                    priceList = view_PriceBusinessLogic.GetPriceByEndDate(munename, endDate);
                }
            }
            else
            {
                if (startDate == "" && endDate == "")
                {
                    //startDate != "";
                    priceList = view_PriceBusinessLogic.GetAllPrice();
                }
                if (startDate != "" && endDate != "")
                {
                    //startDate != "";
                    priceList = view_PriceBusinessLogic.GetAllPriceByDate(startDate, endDate);
                }
                if (startDate != "" && endDate == "")
                {
                    priceList = view_PriceBusinessLogic.GetAllPriceByStartDate(startDate);
                }
                if (startDate == "" && endDate != "")
                {
                    priceList = view_PriceBusinessLogic.GetAllPriceByEndDate(endDate);
                }
            }
            
            this.dataGridView1.DataSource = priceList;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txbdate1.Text = dateTimePicker1.Value.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txbdate2.Text = dateTimePicker2.Value.ToString();
        }

        private void txbdate1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                txbdate1.Text = "";
            }
        }

        private void txbdate2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                txbdate2.Text = "";
            }
        }
    }
}

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
    public partial class AddProviderForm : Form
    {
        public AddProviderForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Provider provider = new Model.Provider();
            provider.ProviderID = txbProviderID.Text;
            provider.ProviderName = txbProviderName.Text.Trim();
            provider.Tel = txbProviderTel.Text.Trim();
            provider.Contact = txbContact.Text.Trim();
            provider.Address = txbAddress.Text.Trim();
            provider.Remark = txbRemark.Text.Trim();
            provider.InputDate = DateTime.Now;
           ProviderBusinessLogic providerBusinessLogic = new ProviderBusinessLogic();
            try
            {
                if (providerBusinessLogic.AddProvider(provider))
                {
                    MessageBox.Show("添加成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            catch
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

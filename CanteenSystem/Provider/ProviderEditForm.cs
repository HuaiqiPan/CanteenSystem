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

namespace CanteenSystem.Provider
{
    public partial class ProviderEditForm : Form
    {
        ProviderBusinessLogic providerBusinessLogic = new ProviderBusinessLogic();
        Model.Provider provider = new Model.Provider();
        public ProviderEditForm(string providerID)
        {
            InitializeComponent();
            provider = providerBusinessLogic.GetProviderByID(providerID);
            txbProviderID.Text= provider.ProviderID;
            txbProviderName.Text= provider.ProviderName;
            txbProviderTel.Text= provider.Tel;
            txbContact.Text= provider.Contact;
            txbAddress.Text= provider.Address;
            txbRemark.Text= provider.Remark;
        }

        private void ProviderEditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            provider.ProviderID = txbProviderID.Text;
            provider.ProviderName = txbProviderName.Text.Trim();
            provider.Tel = txbProviderTel.Text.Trim();
            provider.Contact = txbContact.Text.Trim();
            provider.Address = txbAddress.Text.Trim();
            provider.Remark = txbRemark.Text.Trim();
            if (providerBusinessLogic.UpdataProvider(provider))
                {
                    Console.Write(provider.Address);
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
        }
    }
}

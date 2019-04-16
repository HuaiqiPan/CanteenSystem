namespace CanteenSystem.Provider
{
    partial class AddProviderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbProviderID = new System.Windows.Forms.TextBox();
            this.txbProviderName = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbProviderTel = new System.Windows.Forms.TextBox();
            this.txbContact = new System.Windows.Forms.TextBox();
            this.txbRemark = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供应商编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "供应商名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "供应商地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "供应商电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "联系人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注：";
            // 
            // txbProviderID
            // 
            this.txbProviderID.Location = new System.Drawing.Point(207, 64);
            this.txbProviderID.Name = "txbProviderID";
            this.txbProviderID.Size = new System.Drawing.Size(100, 21);
            this.txbProviderID.TabIndex = 6;
            // 
            // txbProviderName
            // 
            this.txbProviderName.Location = new System.Drawing.Point(516, 64);
            this.txbProviderName.Name = "txbProviderName";
            this.txbProviderName.Size = new System.Drawing.Size(100, 21);
            this.txbProviderName.TabIndex = 7;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(207, 143);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(100, 21);
            this.txbAddress.TabIndex = 8;
            // 
            // txbProviderTel
            // 
            this.txbProviderTel.Location = new System.Drawing.Point(516, 144);
            this.txbProviderTel.Name = "txbProviderTel";
            this.txbProviderTel.Size = new System.Drawing.Size(100, 21);
            this.txbProviderTel.TabIndex = 9;
            // 
            // txbContact
            // 
            this.txbContact.Location = new System.Drawing.Point(207, 239);
            this.txbContact.Name = "txbContact";
            this.txbContact.Size = new System.Drawing.Size(100, 21);
            this.txbContact.TabIndex = 10;
            // 
            // txbRemark
            // 
            this.txbRemark.Location = new System.Drawing.Point(516, 239);
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.Size = new System.Drawing.Size(100, 21);
            this.txbRemark.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 510);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txbRemark);
            this.Controls.Add(this.txbContact);
            this.Controls.Add(this.txbProviderTel);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbProviderName);
            this.Controls.Add(this.txbProviderID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProviderForm";
            this.Text = "添加供应商";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbProviderID;
        private System.Windows.Forms.TextBox txbProviderName;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbProviderTel;
        private System.Windows.Forms.TextBox txbContact;
        private System.Windows.Forms.TextBox txbRemark;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
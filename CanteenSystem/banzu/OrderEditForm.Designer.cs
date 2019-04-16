namespace CanteenSystem.banzu
{
    partial class OrderEditForm
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
            this.dgvOrderEdit = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbGroup = new System.Windows.Forms.TextBox();
            this.txbCreator = new System.Windows.Forms.TextBox();
            this.dtpOrderTime = new System.Windows.Forms.DateTimePicker();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.txbRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxProvider = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderEdit
            // 
            this.dgvOrderEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderEdit.Location = new System.Drawing.Point(12, 182);
            this.dgvOrderEdit.Name = "dgvOrderEdit";
            this.dgvOrderEdit.RowTemplate.Height = 23;
            this.dgvOrderEdit.Size = new System.Drawing.Size(911, 416);
            this.dgvOrderEdit.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(432, 676);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 29);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "发送";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "班组：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "下单人：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "下单时间：";
            // 
            // txbGroup
            // 
            this.txbGroup.Location = new System.Drawing.Point(142, 134);
            this.txbGroup.Name = "txbGroup";
            this.txbGroup.Size = new System.Drawing.Size(100, 21);
            this.txbGroup.TabIndex = 6;
            // 
            // txbCreator
            // 
            this.txbCreator.Location = new System.Drawing.Point(317, 135);
            this.txbCreator.Name = "txbCreator";
            this.txbCreator.Size = new System.Drawing.Size(100, 21);
            this.txbCreator.TabIndex = 7;
            // 
            // dtpOrderTime
            // 
            this.dtpOrderTime.Location = new System.Drawing.Point(499, 134);
            this.dtpOrderTime.Name = "dtpOrderTime";
            this.dtpOrderTime.Size = new System.Drawing.Size(158, 21);
            this.dtpOrderTime.TabIndex = 8;
            // 
            // txbStatus
            // 
            this.txbStatus.ForeColor = System.Drawing.Color.Red;
            this.txbStatus.Location = new System.Drawing.Point(12, 134);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(67, 21);
            this.txbStatus.TabIndex = 9;
            // 
            // txbRemark
            // 
            this.txbRemark.Location = new System.Drawing.Point(148, 604);
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.Size = new System.Drawing.Size(436, 56);
            this.txbRemark.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(69, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "供应商：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(370, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 35);
            this.label6.TabIndex = 17;
            this.label6.Text = "订单审核";
            // 
            // cbxProvider
            // 
            this.cbxProvider.FormattingEnabled = true;
            this.cbxProvider.Location = new System.Drawing.Point(724, 134);
            this.cbxProvider.Name = "cbxProvider";
            this.cbxProvider.Size = new System.Drawing.Size(199, 20);
            this.cbxProvider.TabIndex = 18;
            this.cbxProvider.DropDown += new System.EventHandler(this.cbxProvider_DropDown);
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 754);
            this.Controls.Add(this.cbxProvider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbRemark);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.dtpOrderTime);
            this.Controls.Add(this.txbCreator);
            this.Controls.Add(this.txbGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvOrderEdit);
            this.Name = "OrderEditForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "修改订单";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderEdit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbGroup;
        private System.Windows.Forms.TextBox txbCreator;
        private System.Windows.Forms.DateTimePicker dtpOrderTime;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.TextBox txbRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxProvider;
    }
}
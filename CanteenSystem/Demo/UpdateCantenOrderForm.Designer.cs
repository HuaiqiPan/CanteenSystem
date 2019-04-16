namespace CanteenSystem
{
    partial class UpdateCantenOrderForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labCanteenOrderCount = new System.Windows.Forms.Label();
            this.labCateenOrderMoney = new System.Windows.Forms.Label();
            this.labCanteenOrderName = new System.Windows.Forms.Label();
            this.txtCanteenOrderCount = new System.Windows.Forms.TextBox();
            this.txtCanteenOrderMoney = new System.Windows.Forms.TextBox();
            this.txtCanteenName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(117, 123);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(31, 123);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 38);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labCanteenOrderCount
            // 
            this.labCanteenOrderCount.AutoSize = true;
            this.labCanteenOrderCount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCanteenOrderCount.Location = new System.Drawing.Point(28, 83);
            this.labCanteenOrderCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCanteenOrderCount.Name = "labCanteenOrderCount";
            this.labCanteenOrderCount.Size = new System.Drawing.Size(89, 20);
            this.labCanteenOrderCount.TabIndex = 13;
            this.labCanteenOrderCount.Text = "订单数量";
            // 
            // labCateenOrderMoney
            // 
            this.labCateenOrderMoney.AutoSize = true;
            this.labCateenOrderMoney.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCateenOrderMoney.Location = new System.Drawing.Point(28, 49);
            this.labCateenOrderMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCateenOrderMoney.Name = "labCateenOrderMoney";
            this.labCateenOrderMoney.Size = new System.Drawing.Size(89, 20);
            this.labCateenOrderMoney.TabIndex = 12;
            this.labCateenOrderMoney.Text = "订单价格";
            // 
            // labCanteenOrderName
            // 
            this.labCanteenOrderName.AutoSize = true;
            this.labCanteenOrderName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCanteenOrderName.Location = new System.Drawing.Point(28, 14);
            this.labCanteenOrderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCanteenOrderName.Name = "labCanteenOrderName";
            this.labCanteenOrderName.Size = new System.Drawing.Size(89, 20);
            this.labCanteenOrderName.TabIndex = 11;
            this.labCanteenOrderName.Text = "订单名称";
            // 
            // txtCanteenOrderCount
            // 
            this.txtCanteenOrderCount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCanteenOrderCount.Location = new System.Drawing.Point(117, 81);
            this.txtCanteenOrderCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCanteenOrderCount.Name = "txtCanteenOrderCount";
            this.txtCanteenOrderCount.Size = new System.Drawing.Size(126, 30);
            this.txtCanteenOrderCount.TabIndex = 10;
            // 
            // txtCanteenOrderMoney
            // 
            this.txtCanteenOrderMoney.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCanteenOrderMoney.Location = new System.Drawing.Point(117, 46);
            this.txtCanteenOrderMoney.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCanteenOrderMoney.Name = "txtCanteenOrderMoney";
            this.txtCanteenOrderMoney.Size = new System.Drawing.Size(126, 30);
            this.txtCanteenOrderMoney.TabIndex = 9;
            // 
            // txtCanteenName
            // 
            this.txtCanteenName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCanteenName.Location = new System.Drawing.Point(117, 11);
            this.txtCanteenName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCanteenName.Name = "txtCanteenName";
            this.txtCanteenName.Size = new System.Drawing.Size(126, 30);
            this.txtCanteenName.TabIndex = 8;
            // 
            // UpdateCantenOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 182);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labCanteenOrderCount);
            this.Controls.Add(this.labCateenOrderMoney);
            this.Controls.Add(this.labCanteenOrderName);
            this.Controls.Add(this.txtCanteenOrderCount);
            this.Controls.Add(this.txtCanteenOrderMoney);
            this.Controls.Add(this.txtCanteenName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateCantenOrderForm";
            this.Text = "修改订单";
            this.Load += new System.EventHandler(this.UpdateCantenOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labCanteenOrderCount;
        private System.Windows.Forms.Label labCateenOrderMoney;
        private System.Windows.Forms.Label labCanteenOrderName;
        private System.Windows.Forms.TextBox txtCanteenOrderCount;
        private System.Windows.Forms.TextBox txtCanteenOrderMoney;
        private System.Windows.Forms.TextBox txtCanteenName;
    }
}
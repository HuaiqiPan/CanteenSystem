namespace CanteenSystem
{
    partial class AddCantenOrderForm
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
            this.txtCanteenName = new System.Windows.Forms.TextBox();
            this.txtCanteenOrderMoney = new System.Windows.Forms.TextBox();
            this.txtCanteenOrderCount = new System.Windows.Forms.TextBox();
            this.labCanteenOrderName = new System.Windows.Forms.Label();
            this.labCateenOrderMoney = new System.Windows.Forms.Label();
            this.labCanteenOrderCount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCanteenName
            // 
            this.txtCanteenName.Location = new System.Drawing.Point(116, 10);
            this.txtCanteenName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCanteenName.Name = "txtCanteenName";
            this.txtCanteenName.Size = new System.Drawing.Size(76, 21);
            this.txtCanteenName.TabIndex = 0;
            // 
            // txtCanteenOrderMoney
            // 
            this.txtCanteenOrderMoney.Location = new System.Drawing.Point(116, 34);
            this.txtCanteenOrderMoney.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCanteenOrderMoney.Name = "txtCanteenOrderMoney";
            this.txtCanteenOrderMoney.Size = new System.Drawing.Size(76, 21);
            this.txtCanteenOrderMoney.TabIndex = 1;
            // 
            // txtCanteenOrderCount
            // 
            this.txtCanteenOrderCount.Location = new System.Drawing.Point(116, 59);
            this.txtCanteenOrderCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCanteenOrderCount.Name = "txtCanteenOrderCount";
            this.txtCanteenOrderCount.Size = new System.Drawing.Size(76, 21);
            this.txtCanteenOrderCount.TabIndex = 2;
            // 
            // labCanteenOrderName
            // 
            this.labCanteenOrderName.AutoSize = true;
            this.labCanteenOrderName.Location = new System.Drawing.Point(61, 12);
            this.labCanteenOrderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCanteenOrderName.Name = "labCanteenOrderName";
            this.labCanteenOrderName.Size = new System.Drawing.Size(53, 12);
            this.labCanteenOrderName.TabIndex = 3;
            this.labCanteenOrderName.Text = "订单名称";
            // 
            // labCateenOrderMoney
            // 
            this.labCateenOrderMoney.AutoSize = true;
            this.labCateenOrderMoney.Location = new System.Drawing.Point(61, 37);
            this.labCateenOrderMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCateenOrderMoney.Name = "labCateenOrderMoney";
            this.labCateenOrderMoney.Size = new System.Drawing.Size(53, 12);
            this.labCateenOrderMoney.TabIndex = 4;
            this.labCateenOrderMoney.Text = "订单价格";
            // 
            // labCanteenOrderCount
            // 
            this.labCanteenOrderCount.AutoSize = true;
            this.labCanteenOrderCount.Location = new System.Drawing.Point(61, 62);
            this.labCanteenOrderCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCanteenOrderCount.Name = "labCanteenOrderCount";
            this.labCanteenOrderCount.Size = new System.Drawing.Size(53, 12);
            this.labCanteenOrderCount.TabIndex = 5;
            this.labCanteenOrderCount.Text = "订单数量";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(71, 84);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 18);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 84);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 18);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddCantenOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 118);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labCanteenOrderCount);
            this.Controls.Add(this.labCateenOrderMoney);
            this.Controls.Add(this.labCanteenOrderName);
            this.Controls.Add(this.txtCanteenOrderCount);
            this.Controls.Add(this.txtCanteenOrderMoney);
            this.Controls.Add(this.txtCanteenName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddCantenOrderForm";
            this.Text = "添加订单";
            this.Load += new System.EventHandler(this.AddCantenOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCanteenName;
        private System.Windows.Forms.TextBox txtCanteenOrderMoney;
        private System.Windows.Forms.TextBox txtCanteenOrderCount;
        private System.Windows.Forms.Label labCanteenOrderName;
        private System.Windows.Forms.Label labCateenOrderMoney;
        private System.Windows.Forms.Label labCanteenOrderCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}
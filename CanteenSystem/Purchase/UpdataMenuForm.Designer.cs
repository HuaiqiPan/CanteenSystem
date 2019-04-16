namespace CanteenSystem.Purchase
{
    partial class UpdataMenuForm
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
            this.txbMenuName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUint = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbQuote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbInputDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜品名称：";
            // 
            // txbMenuName
            // 
            this.txbMenuName.Location = new System.Drawing.Point(157, 81);
            this.txbMenuName.Name = "txbMenuName";
            this.txbMenuName.Size = new System.Drawing.Size(100, 21);
            this.txbMenuName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "单位：";
            // 
            // txbUint
            // 
            this.txbUint.Location = new System.Drawing.Point(157, 136);
            this.txbUint.Name = "txbUint";
            this.txbUint.Size = new System.Drawing.Size(100, 21);
            this.txbUint.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbQuote
            // 
            this.txbQuote.Location = new System.Drawing.Point(159, 189);
            this.txbQuote.Name = "txbQuote";
            this.txbQuote.Size = new System.Drawing.Size(100, 21);
            this.txbQuote.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "报价：";
            // 
            // txbRate
            // 
            this.txbRate.Location = new System.Drawing.Point(159, 233);
            this.txbRate.Name = "txbRate";
            this.txbRate.Size = new System.Drawing.Size(100, 21);
            this.txbRate.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "优惠率：";
            // 
            // txbInputDate
            // 
            this.txbInputDate.Location = new System.Drawing.Point(157, 296);
            this.txbInputDate.Name = "txbInputDate";
            this.txbInputDate.Size = new System.Drawing.Size(100, 21);
            this.txbInputDate.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "日期：";
            // 
            // UpdataMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 420);
            this.Controls.Add(this.txbInputDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbQuote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbUint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMenuName);
            this.Controls.Add(this.label1);
            this.Name = "UpdataMenuForm";
            this.Text = "更新菜品";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMenuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbQuote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbInputDate;
        private System.Windows.Forms.Label label6;
    }
}
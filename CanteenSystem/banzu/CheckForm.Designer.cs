namespace CanteenSystem.banzu
{
    partial class CheckFrom
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
            this.txbProvider = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.dtpOrderTime = new System.Windows.Forms.DateTimePicker();
            this.txbCreator = new System.Windows.Forms.TextBox();
            this.txbDepartment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvOrderCheck = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txbOrderId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // txbProvider
            // 
            this.txbProvider.Location = new System.Drawing.Point(876, 138);
            this.txbProvider.Name = "txbProvider";
            this.txbProvider.ReadOnly = true;
            this.txbProvider.Size = new System.Drawing.Size(248, 21);
            this.txbProvider.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "供应商：";
            // 
            // txbStatus
            // 
            this.txbStatus.ForeColor = System.Drawing.Color.Red;
            this.txbStatus.Location = new System.Drawing.Point(118, 138);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(93, 21);
            this.txbStatus.TabIndex = 26;
            // 
            // dtpOrderTime
            // 
            this.dtpOrderTime.Location = new System.Drawing.Point(622, 138);
            this.dtpOrderTime.Name = "dtpOrderTime";
            this.dtpOrderTime.Size = new System.Drawing.Size(178, 21);
            this.dtpOrderTime.TabIndex = 25;
            // 
            // txbCreator
            // 
            this.txbCreator.Location = new System.Drawing.Point(440, 139);
            this.txbCreator.Name = "txbCreator";
            this.txbCreator.ReadOnly = true;
            this.txbCreator.Size = new System.Drawing.Size(100, 21);
            this.txbCreator.TabIndex = 24;
            // 
            // txbDepartment
            // 
            this.txbDepartment.Location = new System.Drawing.Point(262, 138);
            this.txbDepartment.Name = "txbDepartment";
            this.txbDepartment.ReadOnly = true;
            this.txbDepartment.Size = new System.Drawing.Size(100, 21);
            this.txbDepartment.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "下单时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "下单人：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "班组：";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(567, 715);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 33);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "确定验收";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvOrderCheck
            // 
            this.dgvOrderCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderCheck.Location = new System.Drawing.Point(25, 187);
            this.dgvOrderCheck.Name = "dgvOrderCheck";
            this.dgvOrderCheck.RowTemplate.Height = 23;
            this.dgvOrderCheck.Size = new System.Drawing.Size(1130, 416);
            this.dgvOrderCheck.TabIndex = 17;
            this.dgvOrderCheck.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderCheck_CellContentClick);
            this.dgvOrderCheck.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderCheck_CellEndEdit);
            this.dgvOrderCheck.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderCheck_CellValueChanged);
            this.dgvOrderCheck.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvOrderCheck_RowStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "订单编号：";
            // 
            // txbOrderId
            // 
            this.txbOrderId.Location = new System.Drawing.Point(118, 100);
            this.txbOrderId.Name = "txbOrderId";
            this.txbOrderId.ReadOnly = true;
            this.txbOrderId.Size = new System.Drawing.Size(128, 21);
            this.txbOrderId.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(767, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "总金额：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(852, 634);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(487, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 35);
            this.label8.TabIndex = 35;
            this.label8.Text = "订单验收";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(212, 214);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 136);
            this.listBox1.TabIndex = 36;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(54, 651);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 38;
            this.label9.Text = "备注：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 634);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 56);
            this.textBox1.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 39;
            this.label10.Text = "订单状态：";
            // 
            // CheckFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 805);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbOrderId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbProvider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.dtpOrderTime);
            this.Controls.Add(this.txbCreator);
            this.Controls.Add(this.txbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvOrderCheck);
            this.Name = "CheckFrom";
            this.Text = "验收订单";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.DateTimePicker dtpOrderTime;
        private System.Windows.Forms.TextBox txbCreator;
        private System.Windows.Forms.TextBox txbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvOrderCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbOrderId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}
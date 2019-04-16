namespace CanteenSystem.banzu
{
    partial class ApplyForm_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbOrderDate = new System.Windows.Forms.TextBox();
            this.txbOrderNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDepartment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCreater = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuName,
            this.Guige,
            this.Unit,
            this.Count,
            this.Quote,
            this.Rate,
            this.Price,
            this.Money});
            this.dataGridView1.Location = new System.Drawing.Point(21, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(880, 353);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // MenuName
            // 
            this.MenuName.HeaderText = "菜品名称*";
            this.MenuName.Name = "MenuName";
            this.MenuName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuName.Width = 105;
            // 
            // Guige
            // 
            this.Guige.HeaderText = "规格";
            this.Guige.Name = "Guige";
            this.Guige.ReadOnly = true;
            this.Guige.Width = 104;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "单位";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 105;
            // 
            // Count
            // 
            this.Count.HeaderText = "数量*";
            this.Count.Name = "Count";
            this.Count.Width = 104;
            // 
            // Quote
            // 
            this.Quote.HeaderText = "报价";
            this.Quote.Name = "Quote";
            this.Quote.ReadOnly = true;
            this.Quote.Width = 105;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "优惠率";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 104;
            // 
            // Price
            // 
            this.Price.HeaderText = "单价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 105;
            // 
            // Money
            // 
            this.Money.HeaderText = "金额";
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            this.Money.Width = 104;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(172, 219);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 208);
            this.listBox1.TabIndex = 13;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "单据日期：";
            // 
            // txbOrderDate
            // 
            this.txbOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbOrderDate.Location = new System.Drawing.Point(118, 114);
            this.txbOrderDate.Name = "txbOrderDate";
            this.txbOrderDate.ReadOnly = true;
            this.txbOrderDate.Size = new System.Drawing.Size(174, 21);
            this.txbOrderDate.TabIndex = 15;
            // 
            // txbOrderNumber
            // 
            this.txbOrderNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbOrderNumber.Location = new System.Drawing.Point(373, 114);
            this.txbOrderNumber.Name = "txbOrderNumber";
            this.txbOrderNumber.ReadOnly = true;
            this.txbOrderNumber.Size = new System.Drawing.Size(146, 21);
            this.txbOrderNumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "单据编号：";
            // 
            // txbDepartment
            // 
            this.txbDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbDepartment.Location = new System.Drawing.Point(578, 114);
            this.txbDepartment.Name = "txbDepartment";
            this.txbDepartment.ReadOnly = true;
            this.txbDepartment.Size = new System.Drawing.Size(100, 21);
            this.txbDepartment.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "部门：";
            // 
            // txbCreater
            // 
            this.txbCreater.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCreater.Location = new System.Drawing.Point(744, 117);
            this.txbCreater.Name = "txbCreater";
            this.txbCreater.ReadOnly = true;
            this.txbCreater.Size = new System.Drawing.Size(100, 21);
            this.txbCreater.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "请购人：";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(441, 563);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(379, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 35);
            this.label5.TabIndex = 23;
            this.label5.Text = "请购单";
            // 
            // ApplyForm_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 645);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbCreater);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbOrderNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbOrderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ApplyForm_Form";
            this.Text = "请购单";
            this.Load += new System.EventHandler(this.ApplyForm_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbOrderDate;
        private System.Windows.Forms.TextBox txbOrderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCreater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guige;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
    }
}
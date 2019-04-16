namespace CanteenSystem.banzu
{
    partial class BanzuForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddOrder = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOrderTime = new System.Windows.Forms.DateTimePicker();
            this.bntCommitOrder = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.txbCreator = new System.Windows.Forms.TextBox();
            this.txbGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Uncommitted = new System.Windows.Forms.TabPage();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Committed = new System.Windows.Forms.TabPage();
            this.dgvSubmitOrder = new System.Windows.Forms.DataGridView();
            this.Pass = new System.Windows.Forms.TabPage();
            this.dgvPassOrder = new System.Windows.Forms.DataGridView();
            this.Nopass = new System.Windows.Forms.TabPage();
            this.dgvNoPassOrder = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.AddOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.Uncommitted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.Committed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmitOrder)).BeginInit();
            this.Pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassOrder)).BeginInit();
            this.Nopass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoPassOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddOrder);
            this.tabControl1.Controls.Add(this.Uncommitted);
            this.tabControl1.Controls.Add(this.Committed);
            this.tabControl1.Controls.Add(this.Pass);
            this.tabControl1.Controls.Add(this.Nopass);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1554, 724);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AddOrder
            // 
            this.AddOrder.Controls.Add(this.groupBox1);
            this.AddOrder.Location = new System.Drawing.Point(4, 22);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Padding = new System.Windows.Forms.Padding(3);
            this.AddOrder.Size = new System.Drawing.Size(1546, 698);
            this.AddOrder.TabIndex = 5;
            this.AddOrder.Text = "添加订单";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpOrderTime);
            this.groupBox1.Controls.Add(this.bntCommitOrder);
            this.groupBox1.Controls.Add(this.dgvMenu);
            this.groupBox1.Controls.Add(this.btnSaveOrder);
            this.groupBox1.Controls.Add(this.txbCreator);
            this.groupBox1.Controls.Add(this.txbGroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 641);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单管理";
            // 
            // dtpOrderTime
            // 
            this.dtpOrderTime.Location = new System.Drawing.Point(502, 26);
            this.dtpOrderTime.Name = "dtpOrderTime";
            this.dtpOrderTime.Size = new System.Drawing.Size(154, 21);
            this.dtpOrderTime.TabIndex = 9;
            // 
            // bntCommitOrder
            // 
            this.bntCommitOrder.Location = new System.Drawing.Point(445, 598);
            this.bntCommitOrder.Name = "bntCommitOrder";
            this.bntCommitOrder.Size = new System.Drawing.Size(80, 28);
            this.bntCommitOrder.TabIndex = 1;
            this.bntCommitOrder.Text = "提交";
            this.bntCommitOrder.UseVisualStyleBackColor = true;
            this.bntCommitOrder.Click += new System.EventHandler(this.bntCommitOrder_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMenu.Location = new System.Drawing.Point(12, 66);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowTemplate.Height = 23;
            this.dgvMenu.Size = new System.Drawing.Size(722, 516);
            this.dgvMenu.TabIndex = 2;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(200, 598);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(80, 28);
            this.btnSaveOrder.TabIndex = 0;
            this.btnSaveOrder.Text = "保存";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // txbCreator
            // 
            this.txbCreator.Location = new System.Drawing.Point(282, 26);
            this.txbCreator.Name = "txbCreator";
            this.txbCreator.Size = new System.Drawing.Size(100, 21);
            this.txbCreator.TabIndex = 7;
            // 
            // txbGroup
            // 
            this.txbGroup.Location = new System.Drawing.Point(93, 24);
            this.txbGroup.Name = "txbGroup";
            this.txbGroup.Size = new System.Drawing.Size(100, 21);
            this.txbGroup.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "下单时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "下单人：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "班组：";
            // 
            // Uncommitted
            // 
            this.Uncommitted.Controls.Add(this.dgvOrder);
            this.Uncommitted.Location = new System.Drawing.Point(4, 22);
            this.Uncommitted.Name = "Uncommitted";
            this.Uncommitted.Padding = new System.Windows.Forms.Padding(3);
            this.Uncommitted.Size = new System.Drawing.Size(1258, 698);
            this.Uncommitted.TabIndex = 0;
            this.Uncommitted.Text = "未提交";
            this.Uncommitted.UseVisualStyleBackColor = true;
            this.Uncommitted.Click += new System.EventHandler(this.Uncommitted_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(3, 3);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 23;
            this.dgvOrder.Size = new System.Drawing.Size(1252, 692);
            this.dgvOrder.TabIndex = 2;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // Committed
            // 
            this.Committed.Controls.Add(this.dgvSubmitOrder);
            this.Committed.Location = new System.Drawing.Point(4, 22);
            this.Committed.Name = "Committed";
            this.Committed.Padding = new System.Windows.Forms.Padding(3);
            this.Committed.Size = new System.Drawing.Size(1258, 698);
            this.Committed.TabIndex = 1;
            this.Committed.Text = "待审核";
            this.Committed.UseVisualStyleBackColor = true;
            // 
            // dgvSubmitOrder
            // 
            this.dgvSubmitOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubmitOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubmitOrder.Location = new System.Drawing.Point(3, 3);
            this.dgvSubmitOrder.Name = "dgvSubmitOrder";
            this.dgvSubmitOrder.RowTemplate.Height = 23;
            this.dgvSubmitOrder.Size = new System.Drawing.Size(1252, 692);
            this.dgvSubmitOrder.TabIndex = 0;
            this.dgvSubmitOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubmitOrder_CellContentClick);
            // 
            // Pass
            // 
            this.Pass.Controls.Add(this.dgvPassOrder);
            this.Pass.Location = new System.Drawing.Point(4, 22);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(1258, 698);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "已通过";
            this.Pass.UseVisualStyleBackColor = true;
            // 
            // dgvPassOrder
            // 
            this.dgvPassOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPassOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvPassOrder.Name = "dgvPassOrder";
            this.dgvPassOrder.RowTemplate.Height = 23;
            this.dgvPassOrder.Size = new System.Drawing.Size(1258, 698);
            this.dgvPassOrder.TabIndex = 0;
            this.dgvPassOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassOrder_CellContentClick);
            // 
            // Nopass
            // 
            this.Nopass.Controls.Add(this.dgvNoPassOrder);
            this.Nopass.Location = new System.Drawing.Point(4, 22);
            this.Nopass.Name = "Nopass";
            this.Nopass.Size = new System.Drawing.Size(1258, 698);
            this.Nopass.TabIndex = 4;
            this.Nopass.Text = "未通过";
            this.Nopass.UseVisualStyleBackColor = true;
            // 
            // dgvNoPassOrder
            // 
            this.dgvNoPassOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoPassOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoPassOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvNoPassOrder.Name = "dgvNoPassOrder";
            this.dgvNoPassOrder.RowTemplate.Height = 23;
            this.dgvNoPassOrder.Size = new System.Drawing.Size(1258, 698);
            this.dgvNoPassOrder.TabIndex = 0;
            this.dgvNoPassOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNoPassOrder_CellContentClick);
            // 
            // BanzuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 724);
            this.Controls.Add(this.tabControl1);
            this.Name = "BanzuForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "添加订单";
            this.tabControl1.ResumeLayout(false);
            this.AddOrder.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.Uncommitted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.Committed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmitOrder)).EndInit();
            this.Pass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassOrder)).EndInit();
            this.Nopass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoPassOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddOrder;
        private System.Windows.Forms.Button bntCommitOrder;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.TabPage Uncommitted;
        private System.Windows.Forms.TabPage Committed;
        private System.Windows.Forms.TabPage Pass;
        private System.Windows.Forms.TabPage Nopass;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.TextBox txbCreator;
        private System.Windows.Forms.TextBox txbGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOrderTime;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridView dgvSubmitOrder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPassOrder;
        private System.Windows.Forms.DataGridView dgvNoPassOrder;
    }
}
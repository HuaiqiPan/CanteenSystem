using CanteenSystem.UserManage;

namespace CanteenSystem.Purchase
{
    partial class PurchaseForm
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
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMenuName = new System.Windows.Forms.TextBox();
            this.btnSaveMenu = new System.Windows.Forms.Button();
            this.Uint = new System.Windows.Forms.Label();
            this.txbUint = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbQuote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlan
            // 
            this.dgvPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Location = new System.Drawing.Point(103, 91);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowTemplate.Height = 23;
            this.dgvPlan.Size = new System.Drawing.Size(931, 394);
            this.dgvPlan.TabIndex = 0;
            this.dgvPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "菜品名称：";
            // 
            // txbMenuName
            // 
            this.txbMenuName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbMenuName.Location = new System.Drawing.Point(303, 537);
            this.txbMenuName.Name = "txbMenuName";
            this.txbMenuName.Size = new System.Drawing.Size(100, 21);
            this.txbMenuName.TabIndex = 2;
            // 
            // btnSaveMenu
            // 
            this.btnSaveMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveMenu.Location = new System.Drawing.Point(585, 580);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMenu.TabIndex = 7;
            this.btnSaveMenu.Text = "保存菜品";
            this.btnSaveMenu.UseVisualStyleBackColor = true;
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);
            // 
            // Uint
            // 
            this.Uint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Uint.AutoSize = true;
            this.Uint.Location = new System.Drawing.Point(435, 541);
            this.Uint.Name = "Uint";
            this.Uint.Size = new System.Drawing.Size(41, 12);
            this.Uint.TabIndex = 3;
            this.Uint.Text = "单位：";
            // 
            // txbUint
            // 
            this.txbUint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbUint.Location = new System.Drawing.Point(471, 538);
            this.txbUint.Name = "txbUint";
            this.txbUint.Size = new System.Drawing.Size(100, 21);
            this.txbUint.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(959, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除菜品";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(505, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "菜品管理";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "优惠率：";
            // 
            // txbRate
            // 
            this.txbRate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbRate.Location = new System.Drawing.Point(813, 538);
            this.txbRate.Name = "txbRate";
            this.txbRate.Size = new System.Drawing.Size(100, 21);
            this.txbRate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "报价：";
            // 
            // txbQuote
            // 
            this.txbQuote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbQuote.Location = new System.Drawing.Point(627, 539);
            this.txbQuote.Name = "txbQuote";
            this.txbQuote.Size = new System.Drawing.Size(100, 21);
            this.txbQuote.TabIndex = 16;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 647);
            this.Controls.Add(this.txbQuote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txbUint);
            this.Controls.Add(this.Uint);
            this.Controls.Add(this.btnSaveMenu);
            this.Controls.Add(this.txbMenuName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPlan);
            this.Name = "PurchaseForm";
            this.Text = "菜品管理";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMenuName;
        private System.Windows.Forms.Button btnSaveMenu;
        private System.Windows.Forms.Label Uint;
        private System.Windows.Forms.TextBox txbUint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbQuote;
    }
}
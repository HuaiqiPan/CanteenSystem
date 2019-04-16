namespace CanteenSystem
{
    partial class DemoForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCanteenOrder = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.labCanteenOrderCount = new System.Windows.Forms.Label();
            this.labCateenOrderMoney = new System.Windows.Forms.Label();
            this.labCanteenOrderName = new System.Windows.Forms.Label();
            this.txtCanteenOrderCount = new System.Windows.Forms.TextBox();
            this.txtCanteenOrderMoney = new System.Windows.Forms.TextBox();
            this.txtCanteenName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanteenOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCanteenOrder
            // 
            this.dgvCanteenOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanteenOrder.Location = new System.Drawing.Point(9, 83);
            this.dgvCanteenOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCanteenOrder.Name = "dgvCanteenOrder";
            this.dgvCanteenOrder.RowTemplate.Height = 27;
            this.dgvCanteenOrder.Size = new System.Drawing.Size(768, 244);
            this.dgvCanteenOrder.TabIndex = 0;
            this.dgvCanteenOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanteenOrder_CellClick);
            this.dgvCanteenOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanteenOrder_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(254, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchText.Location = new System.Drawing.Point(127, 39);
            this.txtSearchText.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchText.Multiline = true;
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(124, 27);
            this.txtSearchText.TabIndex = 2;
            // 
            // cbxFilter
            // 
            this.cbxFilter.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Location = new System.Drawing.Point(9, 39);
            this.cbxFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(114, 28);
            this.cbxFilter.TabIndex = 3;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(254, 426);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "保存订单";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(430, 34);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Location = new System.Drawing.Point(344, 34);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(85, 34);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // labCanteenOrderCount
            // 
            this.labCanteenOrderCount.AutoSize = true;
            this.labCanteenOrderCount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCanteenOrderCount.Location = new System.Drawing.Point(464, 381);
            this.labCanteenOrderCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCanteenOrderCount.Name = "labCanteenOrderCount";
            this.labCanteenOrderCount.Size = new System.Drawing.Size(89, 20);
            this.labCanteenOrderCount.TabIndex = 12;
            this.labCanteenOrderCount.Text = "订单数量";
            // 
            // labCateenOrderMoney
            // 
            this.labCateenOrderMoney.AutoSize = true;
            this.labCateenOrderMoney.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCateenOrderMoney.Location = new System.Drawing.Point(243, 381);
            this.labCateenOrderMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCateenOrderMoney.Name = "labCateenOrderMoney";
            this.labCateenOrderMoney.Size = new System.Drawing.Size(89, 20);
            this.labCateenOrderMoney.TabIndex = 11;
            this.labCateenOrderMoney.Text = "订单价格";
            // 
            // labCanteenOrderName
            // 
            this.labCanteenOrderName.AutoSize = true;
            this.labCanteenOrderName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCanteenOrderName.Location = new System.Drawing.Point(5, 381);
            this.labCanteenOrderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCanteenOrderName.Name = "labCanteenOrderName";
            this.labCanteenOrderName.Size = new System.Drawing.Size(89, 20);
            this.labCanteenOrderName.TabIndex = 10;
            this.labCanteenOrderName.Text = "订单名称";
            // 
            // txtCanteenOrderCount
            // 
            this.txtCanteenOrderCount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCanteenOrderCount.Location = new System.Drawing.Point(556, 377);
            this.txtCanteenOrderCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtCanteenOrderCount.Name = "txtCanteenOrderCount";
            this.txtCanteenOrderCount.Size = new System.Drawing.Size(76, 30);
            this.txtCanteenOrderCount.TabIndex = 9;
            // 
            // txtCanteenOrderMoney
            // 
            this.txtCanteenOrderMoney.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCanteenOrderMoney.Location = new System.Drawing.Point(332, 377);
            this.txtCanteenOrderMoney.Margin = new System.Windows.Forms.Padding(2);
            this.txtCanteenOrderMoney.Name = "txtCanteenOrderMoney";
            this.txtCanteenOrderMoney.Size = new System.Drawing.Size(129, 30);
            this.txtCanteenOrderMoney.TabIndex = 8;
            // 
            // txtCanteenName
            // 
            this.txtCanteenName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCanteenName.Location = new System.Drawing.Point(94, 377);
            this.txtCanteenName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCanteenName.Name = "txtCanteenName";
            this.txtCanteenName.Size = new System.Drawing.Size(146, 30);
            this.txtCanteenName.TabIndex = 7;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 482);
            this.Controls.Add(this.labCanteenOrderCount);
            this.Controls.Add(this.labCateenOrderMoney);
            this.Controls.Add(this.labCanteenOrderName);
            this.Controls.Add(this.txtCanteenOrderCount);
            this.Controls.Add(this.txtCanteenOrderMoney);
            this.Controls.Add(this.txtCanteenName);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvCanteenOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DemoForm";
            this.Text = "订单管理";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanteenOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCanteenOrder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label labCanteenOrderCount;
        private System.Windows.Forms.Label labCateenOrderMoney;
        private System.Windows.Forms.Label labCanteenOrderName;
        private System.Windows.Forms.TextBox txtCanteenOrderCount;
        private System.Windows.Forms.TextBox txtCanteenOrderMoney;
        private System.Windows.Forms.TextBox txtCanteenName;
    }
}


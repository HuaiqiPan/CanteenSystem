namespace CanteenSystem.Provider
{
    partial class ProviderManageForm
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
            this.dgvProvider = new System.Windows.Forms.DataGridView();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProvider
            // 
            this.dgvProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProvider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvider.Location = new System.Drawing.Point(105, 90);
            this.dgvProvider.Name = "dgvProvider";
            this.dgvProvider.RowTemplate.Height = 23;
            this.dgvProvider.Size = new System.Drawing.Size(1000, 450);
            this.dgvProvider.TabIndex = 0;
            this.dgvProvider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvider_CellContentClick);
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddProvider.Location = new System.Drawing.Point(1008, 54);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(69, 25);
            this.btnAddProvider.TabIndex = 1;
            this.btnAddProvider.Text = "添加";
            this.btnAddProvider.UseVisualStyleBackColor = true;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F);
            this.label1.Location = new System.Drawing.Point(516, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "供应商管理";
            // 
            // ProviderManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProvider);
            this.Controls.Add(this.dgvProvider);
            this.Name = "ProviderManageForm";
            this.Text = "供应商管理";
            this.Load += new System.EventHandler(this.ProviderManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProvider;
        private System.Windows.Forms.Button btnAddProvider;
        private System.Windows.Forms.Label label1;
    }
}
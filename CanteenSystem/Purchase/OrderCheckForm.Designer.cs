namespace CanteenSystem.Purchase
{
    partial class OrderCheckForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbGroup = new System.Windows.Forms.TextBox();
            this.txbCreator = new System.Windows.Forms.TextBox();
            this.dtpOrderTime = new System.Windows.Forms.DateTimePicker();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnNoPass = new System.Windows.Forms.Button();
            this.txbRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderEdit
            // 
            this.dgvOrderEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderEdit.Location = new System.Drawing.Point(2, 73);
            this.dgvOrderEdit.Name = "dgvOrderEdit";
            this.dgvOrderEdit.RowTemplate.Height = 23;
            this.dgvOrderEdit.Size = new System.Drawing.Size(681, 416);
            this.dgvOrderEdit.TabIndex = 0;
            this.dgvOrderEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderEdit_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "班组：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "下单人：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "下单时间：";
            // 
            // txbGroup
            // 
            this.txbGroup.Location = new System.Drawing.Point(148, 29);
            this.txbGroup.Name = "txbGroup";
            this.txbGroup.Size = new System.Drawing.Size(100, 21);
            this.txbGroup.TabIndex = 6;
            // 
            // txbCreator
            // 
            this.txbCreator.Location = new System.Drawing.Point(327, 30);
            this.txbCreator.Name = "txbCreator";
            this.txbCreator.Size = new System.Drawing.Size(100, 21);
            this.txbCreator.TabIndex = 7;
            // 
            // dtpOrderTime
            // 
            this.dtpOrderTime.Location = new System.Drawing.Point(509, 29);
            this.dtpOrderTime.Name = "dtpOrderTime";
            this.dtpOrderTime.Size = new System.Drawing.Size(158, 21);
            this.dtpOrderTime.TabIndex = 8;
            // 
            // txbStatus
            // 
            this.txbStatus.ForeColor = System.Drawing.Color.Red;
            this.txbStatus.Location = new System.Drawing.Point(12, 29);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(67, 21);
            this.txbStatus.TabIndex = 9;
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(462, 579);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(75, 23);
            this.btnPass.TabIndex = 10;
            this.btnPass.Text = "通过";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnNoPass
            // 
            this.btnNoPass.Location = new System.Drawing.Point(137, 579);
            this.btnNoPass.Name = "btnNoPass";
            this.btnNoPass.Size = new System.Drawing.Size(75, 23);
            this.btnNoPass.TabIndex = 11;
            this.btnNoPass.Text = "不通过";
            this.btnNoPass.UseVisualStyleBackColor = true;
            this.btnNoPass.Click += new System.EventHandler(this.btnNoPass_Click);
            // 
            // txbRemark
            // 
            this.txbRemark.Location = new System.Drawing.Point(148, 499);
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
            this.label4.Location = new System.Drawing.Point(69, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "备注：";
            // 
            // OrderCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 638);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbRemark);
            this.Controls.Add(this.btnNoPass);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.dtpOrderTime);
            this.Controls.Add(this.txbCreator);
            this.Controls.Add(this.txbGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrderEdit);
            this.Name = "OrderCheckForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "订单审核";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbGroup;
        private System.Windows.Forms.TextBox txbCreator;
        private System.Windows.Forms.DateTimePicker dtpOrderTime;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnNoPass;
        private System.Windows.Forms.TextBox txbRemark;
        private System.Windows.Forms.Label label4;
    }
}
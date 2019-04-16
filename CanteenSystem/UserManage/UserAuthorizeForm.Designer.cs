namespace CanteenSystem.UserManage
{
    partial class UserAuthorizeForm
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
            this.dgvUGR = new System.Windows.Forms.DataGridView();
            this.AddGroup = new System.Windows.Forms.Button();
            this.dgvUserInGroup = new System.Windows.Forms.DataGridView();
            this.dgvusers = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txbGroupID = new System.Windows.Forms.TextBox();
            this.txbUserID = new System.Windows.Forms.TextBox();
            this.txbugrID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUGR
            // 
            this.dgvUGR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUGR.Location = new System.Drawing.Point(14, 131);
            this.dgvUGR.Name = "dgvUGR";
            this.dgvUGR.RowTemplate.Height = 23;
            this.dgvUGR.Size = new System.Drawing.Size(492, 340);
            this.dgvUGR.TabIndex = 0;
            this.dgvUGR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUGR_CellContentClick);
            // 
            // AddGroup
            // 
            this.AddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddGroup.Location = new System.Drawing.Point(204, 518);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(75, 23);
            this.AddGroup.TabIndex = 1;
            this.AddGroup.Text = "添加部门";
            this.AddGroup.UseVisualStyleBackColor = true;
            this.AddGroup.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // dgvUserInGroup
            // 
            this.dgvUserInGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserInGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInGroup.Location = new System.Drawing.Point(522, 131);
            this.dgvUserInGroup.Name = "dgvUserInGroup";
            this.dgvUserInGroup.RowTemplate.Height = 23;
            this.dgvUserInGroup.Size = new System.Drawing.Size(392, 340);
            this.dgvUserInGroup.TabIndex = 2;
            this.dgvUserInGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserInGroup_CellContentClick);
            // 
            // dgvusers
            // 
            this.dgvusers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusers.Location = new System.Drawing.Point(1002, 131);
            this.dgvusers.Name = "dgvusers";
            this.dgvusers.RowTemplate.Height = 23;
            this.dgvusers.Size = new System.Drawing.Size(249, 340);
            this.dgvusers.TabIndex = 3;
            this.dgvusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusers_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Location = new System.Drawing.Point(920, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "<< 添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemove.Location = new System.Drawing.Point(920, 287);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "移除 >>";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txbGroupID
            // 
            this.txbGroupID.Location = new System.Drawing.Point(14, 12);
            this.txbGroupID.Name = "txbGroupID";
            this.txbGroupID.Size = new System.Drawing.Size(100, 21);
            this.txbGroupID.TabIndex = 6;
            // 
            // txbUserID
            // 
            this.txbUserID.Location = new System.Drawing.Point(120, 12);
            this.txbUserID.Name = "txbUserID";
            this.txbUserID.Size = new System.Drawing.Size(100, 21);
            this.txbUserID.TabIndex = 7;
            // 
            // txbugrID
            // 
            this.txbugrID.Location = new System.Drawing.Point(230, 12);
            this.txbugrID.Name = "txbugrID";
            this.txbugrID.Size = new System.Drawing.Size(100, 21);
            this.txbugrID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(497, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "用户分组管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(226, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "部门列表";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1065, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "用户列表";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(537, 498);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 73);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "提示：单击选择用户名和要将用户分配的组别，单击添加按钮即可将用户分配到该组中！";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(600, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "各部门中的用户表";
            // 
            // UserAuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbugrID);
            this.Controls.Add(this.txbUserID);
            this.Controls.Add(this.txbGroupID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvusers);
            this.Controls.Add(this.dgvUserInGroup);
            this.Controls.Add(this.AddGroup);
            this.Controls.Add(this.dgvUGR);
            this.Name = "UserAuthorizeForm";
            this.Text = "用户授权管理";
            this.Load += new System.EventHandler(this.UserAuthorizeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUGR;
        private System.Windows.Forms.Button AddGroup;
        private System.Windows.Forms.DataGridView dgvUserInGroup;
        private System.Windows.Forms.DataGridView dgvusers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txbGroupID;
        private System.Windows.Forms.TextBox txbUserID;
        private System.Windows.Forms.TextBox txbugrID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}
namespace CanteenSystem
{
    partial class AddUserForm
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
            this.UserName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.RealName = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.txbRealName = new System.Windows.Forms.TextBox();
            this.txbMemo = new System.Windows.Forms.TextBox();
            this.Memo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txbMobile = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.Label();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(143, 18);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(41, 12);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "账号：";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(143, 52);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(41, 12);
            this.password.TabIndex = 1;
            this.password.Text = "密码：";
            // 
            // RealName
            // 
            this.RealName.AutoSize = true;
            this.RealName.Location = new System.Drawing.Point(143, 95);
            this.RealName.Name = "RealName";
            this.RealName.Size = new System.Drawing.Size(53, 12);
            this.RealName.TabIndex = 2;
            this.RealName.Text = "用户名：";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Location = new System.Drawing.Point(143, 127);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(41, 12);
            this.Sex.TabIndex = 3;
            this.Sex.Text = "性别：";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(216, 18);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(100, 21);
            this.txbUserName.TabIndex = 1;
            // 
            // txbpassword
            // 
            this.txbpassword.Location = new System.Drawing.Point(216, 52);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.Size = new System.Drawing.Size(100, 21);
            this.txbpassword.TabIndex = 2;
            // 
            // txbRealName
            // 
            this.txbRealName.Location = new System.Drawing.Point(216, 92);
            this.txbRealName.Name = "txbRealName";
            this.txbRealName.Size = new System.Drawing.Size(100, 21);
            this.txbRealName.TabIndex = 3;
            // 
            // txbMemo
            // 
            this.txbMemo.Location = new System.Drawing.Point(216, 298);
            this.txbMemo.Name = "txbMemo";
            this.txbMemo.Size = new System.Drawing.Size(100, 21);
            this.txbMemo.TabIndex = 7;
            // 
            // Memo
            // 
            this.Memo.AutoSize = true;
            this.Memo.Location = new System.Drawing.Point(143, 298);
            this.Memo.Name = "Memo";
            this.Memo.Size = new System.Drawing.Size(41, 12);
            this.Memo.TabIndex = 9;
            this.Memo.Text = "备注：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(305, 379);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(100, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txbMobile
            // 
            this.txbMobile.Location = new System.Drawing.Point(216, 242);
            this.txbMobile.Name = "txbMobile";
            this.txbMobile.Size = new System.Drawing.Size(100, 21);
            this.txbMobile.TabIndex = 6;
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.Location = new System.Drawing.Point(145, 242);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(65, 12);
            this.Mobile.TabIndex = 13;
            this.Mobile.Text = "电话号码：";
            // 
            // cbxSex
            // 
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbxSex.Location = new System.Drawing.Point(216, 127);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(100, 20);
            this.cbxSex.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "出生日期：";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "";
            this.dtpBirthday.Location = new System.Drawing.Point(216, 181);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(164, 21);
            this.dtpBirthday.TabIndex = 5;
            this.dtpBirthday.Value = new System.DateTime(2018, 11, 19, 0, 0, 0, 0);
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 465);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.txbMobile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Memo);
            this.Controls.Add(this.txbMemo);
            this.Controls.Add(this.txbRealName);
            this.Controls.Add(this.txbpassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.RealName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.UserName);
            this.Name = "AddUserForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label RealName;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.TextBox txbRealName;
        private System.Windows.Forms.TextBox txbMemo;
        private System.Windows.Forms.Label Memo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbMobile;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
    }
}
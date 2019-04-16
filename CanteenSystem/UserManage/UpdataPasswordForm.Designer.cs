namespace CanteenSystem.UserManage
{
    partial class UpdataPasswordForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbOldPassword = new System.Windows.Forms.TextBox();
            this.txbNewPassword1 = new System.Windows.Forms.TextBox();
            this.txbNewPassword2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // txbOldPassword
            // 
            this.txbOldPassword.Location = new System.Drawing.Point(118, 28);
            this.txbOldPassword.Name = "txbOldPassword";
            this.txbOldPassword.PasswordChar = '*';
            this.txbOldPassword.Size = new System.Drawing.Size(100, 21);
            this.txbOldPassword.TabIndex = 3;
            // 
            // txbNewPassword1
            // 
            this.txbNewPassword1.Location = new System.Drawing.Point(118, 78);
            this.txbNewPassword1.Name = "txbNewPassword1";
            this.txbNewPassword1.PasswordChar = '*';
            this.txbNewPassword1.Size = new System.Drawing.Size(100, 21);
            this.txbNewPassword1.TabIndex = 4;
            // 
            // txbNewPassword2
            // 
            this.txbNewPassword2.Location = new System.Drawing.Point(118, 132);
            this.txbNewPassword2.Name = "txbNewPassword2";
            this.txbNewPassword2.PasswordChar = '*';
            this.txbNewPassword2.Size = new System.Drawing.Size(100, 21);
            this.txbNewPassword2.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(30, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(164, 194);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(75, 23);
            this.bntOK.TabIndex = 7;
            this.bntOK.Text = "确定";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // UpdataPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txbNewPassword2);
            this.Controls.Add(this.txbNewPassword1);
            this.Controls.Add(this.txbOldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdataPasswordForm";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbOldPassword;
        private System.Windows.Forms.TextBox txbNewPassword1;
        private System.Windows.Forms.TextBox txbNewPassword2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntOK;
    }
}
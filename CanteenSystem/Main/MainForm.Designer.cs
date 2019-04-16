namespace CanteenSystem.Main
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("系统首页");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("增加用户");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("用户分组");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("用户管理", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("添加订单");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("待审核订单");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("待验收订单");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("已验收订单");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("订单管理", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("供应商管理");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("菜品管理");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("价格查询");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("已提交");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("已发送");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("已验收");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("订单查询", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode68,
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("修改密码");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("退出系统");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.PanelRightMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeftMenu.SuspendLayout();
            this.PanelRightMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMenu.Name = "tvMenu";
            treeNode55.Name = "系统首页";
            treeNode55.Tag = "1";
            treeNode55.Text = "系统首页";
            treeNode56.Name = "增加用户";
            treeNode56.Text = "增加用户";
            treeNode57.Name = "用户分组";
            treeNode57.Text = "用户分组";
            treeNode58.Name = "用户管理";
            treeNode58.Tag = "1";
            treeNode58.Text = "用户管理";
            treeNode59.Name = "添加订单";
            treeNode59.Text = "添加订单";
            treeNode60.Name = "待审核订单";
            treeNode60.Text = "待审核订单";
            treeNode61.Name = "待验收订单";
            treeNode61.Text = "待验收订单";
            treeNode62.Name = "已验收订单";
            treeNode62.Text = "已验收订单";
            treeNode63.Name = "订单管理";
            treeNode63.Text = "订单管理";
            treeNode64.Name = "供应商管理";
            treeNode64.Text = "供应商管理";
            treeNode65.Name = "菜品管理";
            treeNode65.Text = "菜品管理";
            treeNode66.Name = "价格查询";
            treeNode66.Text = "价格查询";
            treeNode67.Name = "已提交";
            treeNode67.Text = "已提交";
            treeNode68.Name = "已发送";
            treeNode68.Text = "已发送";
            treeNode69.Name = "已验收";
            treeNode69.Text = "已验收";
            treeNode70.Name = "订单查询";
            treeNode70.Text = "订单查询";
            treeNode71.Name = "修改密码";
            treeNode71.Text = "修改密码";
            treeNode72.Name = "退出系统";
            treeNode72.Text = "退出系统";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode58,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode70,
            treeNode71,
            treeNode72});
            this.tvMenu.Size = new System.Drawing.Size(155, 736);
            this.tvMenu.TabIndex = 1;
            this.tvMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMenu_NodeMouseClick);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Controls.Add(this.tvMenu);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(155, 736);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // PanelRightMain
            // 
            this.PanelRightMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PanelRightMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelRightMain.BackgroundImage")));
            this.PanelRightMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelRightMain.Controls.Add(this.label1);
            this.PanelRightMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRightMain.Location = new System.Drawing.Point(155, 0);
            this.PanelRightMain.Name = "PanelRightMain";
            this.PanelRightMain.Size = new System.Drawing.Size(1329, 736);
            this.PanelRightMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(332, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用广西师范学院食堂采购系统！";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 736);
            this.Controls.Add(this.PanelRightMain);
            this.Controls.Add(this.panelLeftMenu);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "广西师范学院食堂采购系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panelLeftMenu.ResumeLayout(false);
            this.PanelRightMain.ResumeLayout(false);
            this.PanelRightMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelRightMain;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Label label1;
    }
}
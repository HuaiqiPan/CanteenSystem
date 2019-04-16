using CanteenSystem.banzu;
using CanteenSystem.BusinessLogic;
using CanteenSystem.Model;
using CanteenSystem.Provider;
using CanteenSystem.Purchase;
using CanteenSystem.UserManage;
using System;
using System.Windows.Forms;

namespace CanteenSystem.Main
{
    public partial class MainForm : Form
    {
        UserLoginForm loginform { get; set; }
        UserBusinessLogic usersBusinessLogic = new UserBusinessLogic();
        View_GroupBusinessLogic view_GroupBusinessLogic = new View_GroupBusinessLogic();
        Users user;
        View_Group view_Group = new View_Group();
        public MainForm()
        {
            InitializeComponent();
            this.tvMenu.ExpandAll();
        }

        public MainForm(string userID, UserLoginForm userLoginForm)
        {
            user = usersBusinessLogic.GetUserByID(userID);
            loginform = new UserLoginForm();
            loginform = userLoginForm;
            view_Group = view_GroupBusinessLogic.GetView_GroupByUserID(userID);
            InitializeComponent();
            //根据用户组别view_Group.GroupName或者view_Group.Remark移除菜单中不属于该用户的功能
            if (view_Group.Remark == "班组")
            {
                tvMenu.Nodes.Remove(tvMenu.Nodes[4]);
                tvMenu.Nodes.Remove(tvMenu.Nodes[3]);
                tvMenu.Nodes.Remove(tvMenu.Nodes[2].Nodes[3]);
                tvMenu.Nodes.Remove(tvMenu.Nodes[2].Nodes[2]);
                tvMenu.Nodes.Remove(tvMenu.Nodes[2].Nodes[1]);
                tvMenu.Nodes.Remove(tvMenu.Nodes[1]);
            }
            if (view_Group.Remark == "采购组")
            {
                tvMenu.Nodes.Remove(tvMenu.Nodes[6]);
                tvMenu.Nodes.Remove(tvMenu.Nodes[2].Nodes[0]);
                tvMenu.Nodes.Remove(tvMenu.Nodes[1]);
            }
            if (view_Group.Remark == "验收组")
            {
                tvMenu.Nodes.Remove(tvMenu.Nodes[6]);
                tvMenu.Nodes.Remove(tvMenu.Nodes[2].Nodes[0]);
                tvMenu.Nodes.Remove(tvMenu.Nodes[1]);
            }
            this.tvMenu.ExpandAll();//启动时将treeview菜单节点全部展开
        }
        //订单增删改查界面
        private void showbanzuForm()
        {
            this.PanelRightMain.Controls.Clear();
            BanzuForm banzuForm = new BanzuForm(user.UserID);
            banzuForm.TopLevel = false;
            banzuForm.Dock = DockStyle.Fill;//把子窗体设置为控件
            banzuForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(banzuForm);
            banzuForm.Show();
        }
        //请购单界面
        private void showApplyForm()
        {
            this.PanelRightMain.Controls.Clear();
            ApplyForm_Form applyForm = new ApplyForm_Form(user.UserID);
            applyForm.TopLevel = false;
            applyForm.Dock = DockStyle.Fill;//把子窗体设置为控件
            
            applyForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(applyForm);
            applyForm.StartPosition = FormStartPosition.CenterScreen;
            applyForm.Show();
        }

        //订单列表界面
        private void showOrderListForm()
        {
            this.PanelRightMain.Controls.Clear();
            OrderListForm orderListForm = new OrderListForm(user.UserID);
            orderListForm.TopLevel = false;
            orderListForm.Dock = DockStyle.Fill;//把子窗体设置为控件
            orderListForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(orderListForm);
            orderListForm.Show();
        }
        //班组查询自己已提交的订单界面
        private void showBanzuOrderListForm()
        {
            this.PanelRightMain.Controls.Clear();
            BanzuOrderListForm orderListForm = new BanzuOrderListForm(user.UserID);
            orderListForm.TopLevel = false;
            orderListForm.Dock = DockStyle.Fill;//把子窗体设置为控件
            orderListForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(orderListForm);
            orderListForm.Show();
        }
        //班组查询自己的已发送的订单界面
        private void showBanzuOrderListForm1()
        {
            this.PanelRightMain.Controls.Clear();
            BanzuOrderListForm1 orderListForm = new BanzuOrderListForm1(user.UserID);
            orderListForm.TopLevel = false;
            orderListForm.Dock = DockStyle.Fill;//把子窗体设置为控件
            orderListForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(orderListForm);
            orderListForm.Show();
        }
        //班组查询自己的已验收的订单界面
        private void showBanzuOrderListForm2()
        {
            this.PanelRightMain.Controls.Clear();
            BanzuOrderListForm2 orderListForm = new BanzuOrderListForm2(user.UserID);
            orderListForm.TopLevel = false;
            orderListForm.Dock = DockStyle.Fill;//把子窗体设置为控件
            orderListForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(orderListForm);
            orderListForm.Show();
        }
        //待验收订单列表
        private void showCheckOrderForm()
        {
            this.PanelRightMain.Controls.Clear();
            CheckOrderForm checkOrderForm = new CheckOrderForm(user.UserID);
            checkOrderForm.TopLevel = false;
            checkOrderForm.Dock = DockStyle.Fill;//把子窗体设置为控件
            checkOrderForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(checkOrderForm);
            checkOrderForm.Show();
        }

        //查询订单界面
        private void showOrderSearch()
        {
            this.PanelRightMain.Controls.Clear();
            OrderSearch orderSearch = new OrderSearch(user.UserID);
            orderSearch.TopLevel = false;
            orderSearch.Dock = DockStyle.Fill;//把子窗体设置为控件
            orderSearch.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(orderSearch);
            orderSearch.Show();
        }
        //用户增删改成界面
        private void showUserManageForm()
        {
            this.PanelRightMain.Controls.Clear();
            UserManageForm userManageForm = new UserManageForm();
            userManageForm.TopLevel=false;
            userManageForm.Dock = DockStyle.Fill;
            userManageForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(userManageForm);
            userManageForm.Show();
        }
        //用户分组界面
        private void showUserAuthorizeForm()
        {
            this.PanelRightMain.Controls.Clear();
            UserAuthorizeForm userAuthorizeForm = new UserAuthorizeForm();
            userAuthorizeForm.TopLevel = false;
            userAuthorizeForm.Dock = DockStyle.Fill;
            userAuthorizeForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(userAuthorizeForm);
            userAuthorizeForm.Show();
        }
        private void showAddUserForm()
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }
        private void showProviderManageForm()
        {
            this.PanelRightMain.Controls.Clear();
            ProviderManageForm providerManageForm = new ProviderManageForm();
            providerManageForm.TopLevel = false;
            providerManageForm.Dock = DockStyle.Fill;
            providerManageForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(providerManageForm);
            providerManageForm.Show();
        }
        private void showPurchaseForm()
        {
            this.PanelRightMain.Controls.Clear();
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.TopLevel = false;
            purchaseForm.Dock = DockStyle.Fill;
            purchaseForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(purchaseForm);
            purchaseForm.Show();
        }
        private void showPriceSearchForm()
        {
            this.PanelRightMain.Controls.Clear();
            PriceSezrchForm priceSearchForm = new PriceSezrchForm();
            priceSearchForm.TopLevel = false;
            priceSearchForm.Dock = DockStyle.Fill;
            priceSearchForm.FormBorderStyle = FormBorderStyle.None;
            PanelRightMain.Controls.Add(priceSearchForm);
            priceSearchForm.Show();
        }
        private void showUpdataPasswordForm()
        {     
            UpdataPasswordForm updataPasswordForm = new UpdataPasswordForm(user.UserID);
            updataPasswordForm.ShowDialog();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginform.Close();
        }

        private void tvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nodeselect = e.Node.Name;
            switch (nodeselect)
            {
                case "已提交":showBanzuOrderListForm();break;
                case "已发送": showBanzuOrderListForm1(); break;
                case "已验收": showBanzuOrderListForm2(); break;
                case "用户管理": showUserManageForm(); break;
                case "增加用户": showAddUserForm(); break;
                case "用户分组": showUserAuthorizeForm(); break;
                case "添加订单": showApplyForm(); break;
                case "菜品管理": showPurchaseForm(); break;
                case "待审核订单": showOrderListForm(); break;
                case "已验收订单": showOrderSearch(); break;
                case "价格查询": showPriceSearchForm(); break;
                case "待验收订单": showCheckOrderForm(); break;
                case "供应商管理": showProviderManageForm(); break;
                case "修改密码": showUpdataPasswordForm(); break;
                case "退出系统": Application.Exit(); break;
                default: break;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                
                this.WindowState = FormWindowState.Normal;
            }
            
        }
    }
}

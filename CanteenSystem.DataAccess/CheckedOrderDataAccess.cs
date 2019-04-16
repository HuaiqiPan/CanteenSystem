using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class CheckedOrderDataAccess
    {
        CheckedOrderDataContext checkedOrderDataContext;
        MenuCheckedOrder_RDataContext menuCheckedOrder_RDataContext;
        //构造方法
        public CheckedOrderDataAccess()
        {
            this.checkedOrderDataContext = new CheckedOrderDataContext();
            this.menuCheckedOrder_RDataContext = new MenuCheckedOrder_RDataContext();
        }


        //查询所有订单信息
        public List<CheckedOrder> GetAllOrder()
        {
            return this.checkedOrderDataContext.CheckedOrder.ToList();
        }

        public List<MenuCheckedOrder_R> GetOrder(string orderID)
        {
            List<MenuCheckedOrder_R> menuOrder_RList = menuCheckedOrder_RDataContext.MenuCheckedOrder_R.Where(o => o.CheckedOrderID == orderID).ToList();
            return menuOrder_RList;
        }
        //通过主键orderID查询订单信息
        public CheckedOrder GetOrderByID(string checkedOrderID)
        {
            CheckedOrder checkedOrder = new CheckedOrder();
            checkedOrder = this.checkedOrderDataContext.CheckedOrder.SingleOrDefault(o => o.CheckedOrderID == checkedOrderID);
            return checkedOrder;
        }

        //通过订单状态获取订单
        public List<CheckedOrder> GetOrderByStatus(string status)
        {
            List<CheckedOrder> checkedOrderList = new List<CheckedOrder>();
            checkedOrderList = this.checkedOrderDataContext.CheckedOrder.Where(o => o.Status == status).OrderBy(o => o.InputDate).ToList();
            return checkedOrderList;
        }
        //通过部门获取订单
        public List<CheckedOrder> GetOrdersByDepartment(string department)
        {
            List<CheckedOrder> checkedOrderList = new List<CheckedOrder>();
            checkedOrderList = this.checkedOrderDataContext.CheckedOrder.Where(o=>o.Department== department).ToList();
            return checkedOrderList;
        }

        //通过供应商获取订单
        public List<CheckedOrder> GetOrderByProvider(string provider)
        {
            List<CheckedOrder> checkedOrderList = new List<CheckedOrder>();
            checkedOrderList = this.checkedOrderDataContext.CheckedOrder.Where(o => o.Provider == provider).ToList();
            return checkedOrderList;
        }
        public List<CheckedOrder> GetListByPD(string provider, string department)
        {
            List<CheckedOrder> checkedOrderList = new List<CheckedOrder>();
            var q = from p in checkedOrderDataContext.CheckedOrder where (string.IsNullOrEmpty(provider) ? true : p.Provider.Equals(provider)) &&
                   (string.IsNullOrEmpty(department) ? true : p.Department.Equals(department))select p;
            checkedOrderList = q.ToList();
            return checkedOrderList;
        }
        public List<CheckedOrder> GetListByPD(string provider,string department,string startDate,string endDate)
        {
            List<CheckedOrder> checkedOrderList = new List<CheckedOrder>();
            var q = from p in checkedOrderDataContext.CheckedOrder where (string.IsNullOrEmpty(provider) ? true : p.Provider.Equals(provider))&&
                    (string.IsNullOrEmpty(department) ? true : p.Department.Equals(department)) &&
                    (p.InputDate >= DateTime.Parse(startDate) && p.InputDate <= DateTime.Parse(endDate)) select p;
            checkedOrderList =  q.ToList();
            return checkedOrderList;
        }
        public List<CheckedOrder> GetListByStartDate(string provider, string department, string startDate)
        {
            List<CheckedOrder> checkedOrderList = new List<CheckedOrder>();
            var q = from p in checkedOrderDataContext.CheckedOrder where (string.IsNullOrEmpty(provider) ? true : p.Provider.Equals(provider)) &&
                    (string.IsNullOrEmpty(department) ? true : p.Department.Equals(department)) &&(p.InputDate >= DateTime.Parse(startDate))select p;
            checkedOrderList = q.ToList();
            return checkedOrderList;
        }
        public List<CheckedOrder> GetListByEndDate(string provider, string department, string endDate)
        {
            List<CheckedOrder> checkedOrderList = new List<CheckedOrder>();
            var q = from p in checkedOrderDataContext.CheckedOrder where (string.IsNullOrEmpty(provider) ? true : p.Provider.Equals(provider)) &&
                    (string.IsNullOrEmpty(department) ? true : p.Department.Equals(department)) &&(p.InputDate <= DateTime.Parse(endDate))select p;
            checkedOrderList = q.ToList();
            return checkedOrderList;
        }
        //添加订单
        public bool AddOrder(CheckedOrder checkedOrder)
        {
            try
            {
                this.checkedOrderDataContext.CheckedOrder.InsertOnSubmit(checkedOrder);
                this.checkedOrderDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //通过主键OrderID删除订单
        public bool DeleteOrderById(string checkedOrderID)
        {
            try
            {
                CheckedOrder checkedOrder = this.checkedOrderDataContext.CheckedOrder.SingleOrDefault(o => o.CheckedOrderID == checkedOrderID);
                this.checkedOrderDataContext.CheckedOrder.DeleteOnSubmit(checkedOrder);
                this.checkedOrderDataContext.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }

        //更改订单信息
        public bool UpdataOrder(CheckedOrder checkedOrder)
        {
            try
            {
                this.checkedOrderDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class CheckedOrderBusinessLogic
    {
        CheckedOrderDataAccess checkedOrderDataAccess;

        public CheckedOrderBusinessLogic()
        {
            this.checkedOrderDataAccess = new CheckedOrderDataAccess();
        }
        //查询所有订单信息
        public List<CheckedOrder> GetAllOrder()
        {
            return checkedOrderDataAccess.GetAllOrder();
        }

        public List<MenuCheckedOrder_R> GetOrder(string checkedOrderID)
        {
            return checkedOrderDataAccess.GetOrder(checkedOrderID);
        }
        //通过订单状态获取订单
        public List<CheckedOrder> GetOrderByStatus(string status)
        {
            return checkedOrderDataAccess.GetOrderByStatus(status);
        }
        //通过部门获取订单
        public List<CheckedOrder> GetOrdersByDepartment(string department)
        {
            return checkedOrderDataAccess.GetOrdersByDepartment(department);
        }

        //通过部门获取订单
        public List<CheckedOrder> GetOrderByProvider(string department)
        {
            return checkedOrderDataAccess.GetOrderByProvider(department);
        }
        public List<CheckedOrder> GetListByPD(string provider, string department, string startDate, string endDate)
        {
            return checkedOrderDataAccess.GetListByPD(provider,department,startDate,endDate);
        }
        public List<CheckedOrder> GetListByStartDate(string provider, string department, string startDate)
        {
            return checkedOrderDataAccess.GetListByStartDate(provider, department, startDate);
        }
        public List<CheckedOrder> GetListByPD(string provider, string department)
        {
           return checkedOrderDataAccess.GetListByPD(provider, department);
        }
        public List<CheckedOrder> GetListByEndDate(string provider, string department, string endDate)
        {
            return checkedOrderDataAccess.GetListByEndDate(provider, department, endDate);
        }
        //通过主键orderID查询订单信息
        public CheckedOrder GetOrderByID(string checkedOrderID)
        {
            return checkedOrderDataAccess.GetOrderByID(checkedOrderID);
        }

        //添加订单
        public bool AddOrder(CheckedOrder checkedOrder)
        {
            return checkedOrderDataAccess.AddOrder(checkedOrder);

        }

        //通过主键OrderID删除订单
        public bool DeleteOrderById(string checkedOrderID)
        {
            return checkedOrderDataAccess.DeleteOrderById(checkedOrderID);

        }

        //更改订单信息
        public bool UpdataOrder(CheckedOrder checkedOrder)
        {
            return checkedOrderDataAccess.UpdataOrder(checkedOrder);
        }
    }
}

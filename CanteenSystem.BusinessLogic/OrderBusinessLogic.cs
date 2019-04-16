using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class OrderBusinessLogic
    {
        OrderDataAccess orderDataAccess;

       public OrderBusinessLogic()
        {
            this.orderDataAccess = new OrderDataAccess();
        }
        //查询所有订单信息
        public List<Order> GetAllOrder()
        {
            return orderDataAccess.GetAllOrder();
        }

        public List<MenuOrder_R> GetOrder(string orderID)
        {
            return orderDataAccess.GetOrder(orderID);
        }
        //通过订单状态获取订单
        public List<Order> GetOrderByStatus(string status)
        {
            return orderDataAccess.GetOrderByStatus(status);
        }

        public List<Order> GetOrderByStatusAndCreator(string status, string creator)
        {
            return orderDataAccess.GetOrderByStatusAndCreator(status, creator);
        }
        //通过主键orderID查询订单信息
        public Order GetOrderByID(string orderID)
        {

            return orderDataAccess.GetOrderByID(orderID);
        }

        //添加订单
        public bool AddOrder(Order order)
        {
            return orderDataAccess.AddOrder(order);

        }

        //通过主键OrderID删除订单
        public bool DeleteOrderById(string orderID)
        {
            return orderDataAccess.DeleteOrderById(orderID);

        }

        //更改订单信息
        public bool UpdataOrder(Order order)
        {
            return orderDataAccess.UpdataOrder(order);
        }

        public bool IscontainOrder(string orderNumber)
        {
            return orderDataAccess.IscontainOrder(orderNumber);
        }
    }
}

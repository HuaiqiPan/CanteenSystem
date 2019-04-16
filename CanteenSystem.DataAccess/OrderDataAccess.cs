using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class OrderDataAccess
    {
        OrderDataContext orderDataContext;
        MenuDataContext menuDataContext;
        MenuOrder_RDataContext morDataContext;
        //构造方法
        public OrderDataAccess()
        {
            this.orderDataContext = new OrderDataContext();
            this.menuDataContext = new MenuDataContext();
            this.morDataContext = new MenuOrder_RDataContext();
        }


        //查询所有订单信息
        public List<Order> GetAllOrder()
        {
            return this.orderDataContext.Order.ToList();
        }

        //public List<Menu> GetOrder(string orderID)
        //{
        //    List<string> menuIDList = morDataContext.MenuOrder_R.Where(o => o.OrderID == orderID).Select(o => o.MenuID).ToList();
        //    List<Menu> menuList = menuDataContext.Menu.Where(o => menuIDList.Contains(o.MenuID)).ToList();
        //    return menuList;
        //}
        public List<MenuOrder_R> GetOrder(string orderID)
        {
            //List<string> menuIDList = morDataContext.MenuOrder_R.Where(o => o.OrderID == orderID).Select(o => o.MenuID).ToList();
            List<MenuOrder_R> menuOrder_RList = morDataContext.MenuOrder_R.Where(o => o.OrderID==orderID).ToList();
            return menuOrder_RList;
        }
        //通过主键orderID查询订单信息
        public Order GetOrderByID(string orderID)
        {
            Order order = new Order();
            order = this.orderDataContext.Order.SingleOrDefault(o => o.OrderID == orderID);
            return order;
        }

        //通过订单状态获取订单
        public List<Order> GetOrderByStatus(string status)
        {
            List<Order> orderList = new List<Order>();
            orderList = this.orderDataContext.Order.Where(o => o.Status == status).OrderBy(o=>o.InputDate).ToList();
            return orderList;
        }
        public List<Order> GetOrderByStatusAndCreator(string status,string creator)
        {
            List<Order> orderList = new List<Order>();
            orderList = this.orderDataContext.Order.Where(o => o.Status == status&&o.Creator==creator).OrderBy(o => o.InputDate).ToList();
            return orderList;
        }

        //添加订单
        public bool AddOrder(Order order)
        {
            try
            {
                this.orderDataContext.Order.InsertOnSubmit(order);
                this.orderDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //通过主键OrderID删除订单
        public bool DeleteOrderById(string orderID)
        {
            try
            {
                Order order = this.orderDataContext.Order.SingleOrDefault(o => o.OrderID == orderID);
                this.orderDataContext.Order.DeleteOnSubmit(order);
                this.orderDataContext.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }

        //查询订单列表中是否包含该订单
        public bool IscontainOrder(string orderNumber)
        {
            Order order = this.orderDataContext.Order.SingleOrDefault(o => o.OrderNumber == orderNumber);
            bool flag = false;
            if (order!=null)
            {
                flag = true;
            }
            return flag;
        }

        //更改订单信息
        public bool UpdataOrder(Order order)
        {
            try
            {
                this.orderDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

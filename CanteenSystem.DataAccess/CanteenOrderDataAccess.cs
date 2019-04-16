using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenSystem.Model;
using System.Data.Linq;

namespace CanteenSystem.DataAccess
{
    public class CanteenOrderDataAccess
    {
        CanteenOrderDataContext canteenOrderDataContextcontext;

        /// <summary>
        /// 构造函数
        /// </summary>
        public CanteenOrderDataAccess()
        {
            this.canteenOrderDataContextcontext = new CanteenOrderDataContext();
        }

        public List<CanteenOrder> GetAll()
        {
            return this.canteenOrderDataContextcontext.CanteenOrder.ToList();
        }

        /// <summary>
        /// 使用ID查询订单
        /// </summary>
        /// <param name="CanteenOrderKeyID">订单ID</param>
        /// <returns>订单</returns>
        public CanteenOrder GetCanteenOrderByKeyID(string CanteenOrderKeyID)
        {
            CanteenOrder canteenOrder = new CanteenOrder();
            canteenOrder = this.canteenOrderDataContextcontext.CanteenOrder.SingleOrDefault(o => o.CanteenOrderKeyID == CanteenOrderKeyID);
            return canteenOrder;
        }

        /// <summary>
        /// 使用订单名称查询订单
        /// </summary>
        /// <param name="CanteenOrderName">订单名称</param>
        /// <returns>订单列表</returns>
        public List<CanteenOrder> GetCanteenOrderByName(string CanteenOrderName)
        {
            List<CanteenOrder> canteenOrderList = this.canteenOrderDataContextcontext.CanteenOrder.Where(o => o.CanteenOrderName.Contains(CanteenOrderName)).ToList();
            return canteenOrderList;
        }

        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="canteenOrder">订单对象</param>
        /// <returns>添加是否成功</returns>
        public bool Add(CanteenOrder canteenOrder)
        {
            try
            {
                if (canteenOrder != null)
                {
                    this.canteenOrderDataContextcontext.CanteenOrder.InsertOnSubmit(canteenOrder);
                    this.canteenOrderDataContextcontext.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 订单修改
        /// </summary>
        /// <param name="canteenOrder">订单对象</param>
        /// <returns>修改是否成功</returns>
        public bool Update(CanteenOrder canteenOrder)
        {
            try
            {
                this.canteenOrderDataContextcontext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 根据订单ID删除订单
        /// </summary>
        /// <param name="CanteenOrderKeyID">订单ID</param>
        /// <returns>删除是否成功</returns>
        public bool delete(string CanteenOrderKeyID)
        {
            try
            {
                CanteenOrder canteenOrder = this.canteenOrderDataContextcontext.CanteenOrder.SingleOrDefault(o => o.CanteenOrderKeyID == CanteenOrderKeyID);
                if (canteenOrder != null)
                {
                    this.canteenOrderDataContextcontext.CanteenOrder.DeleteOnSubmit(canteenOrder);
                    this.canteenOrderDataContextcontext.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="canteenOrder">订单对象</param>
        /// <returns>删除订单结果</returns>
        public bool delete(CanteenOrder canteenOrder)
        {
            try
            {
                if (canteenOrder != null)
                {
                    this.canteenOrderDataContextcontext.CanteenOrder.DeleteOnSubmit(canteenOrder);
                    this.canteenOrderDataContextcontext.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }

}

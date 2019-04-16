using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class ProviderBusinessLogic
    {
        ProviderDataAccess providerDataAccess;
        public ProviderBusinessLogic()
        {
            this.providerDataAccess = new ProviderDataAccess();
        }
        /// <summary>
        /// 添加供应商
        /// </summary>
        /// <param name="provider"></param>
        /// <returns>是否添加成功</returns>
        public bool AddProvider(Provider provider)
        {
            return this.providerDataAccess.AddProvider(provider);
        }
        /// <summary>
        /// 通过供应商ID删除供应商
        /// </summary>
        /// <param name="providerID"></param>
        /// <returns>是否删除成功</returns>
        public bool DeleteProviderByID(string providerID)
        {
            return this.providerDataAccess.DeleteProviderByID(providerID);

        }
        /// <summary>
        /// 更新供应商信息
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public bool UpdataProvider(Provider provider)
        {
            return this.providerDataAccess.UpdataProvider(provider);
        }
        /// <summary>
        /// 通过供应商ID查询供应商
        /// </summary>
        /// <param name="providerID">供应商ID</param>
        /// <returns>供应商</returns>
        public Provider GetProviderByID(string providerID)
        {
            return this.providerDataAccess.GetProviderByID(providerID);
        }
        /// <summary>
        /// 通过供应商名称查询供应商
        /// </summary>
        /// <param name="providerName">供应商名称</param>
        /// <returns>供应商</returns>
        public Provider GetProviderByName(string providerName)
        {
            return this.providerDataAccess.GetProviderByName(providerName);
        }
        /// <summary>
        /// 通过供应商名称的个别字进行模糊查询
        /// </summary>
        /// <param name="providerName">供应商名称中的某些字</param>
        /// <returns>包含指定字的供应商列表</returns>
        public List<Provider> GetProvidersLike(string providerName)
        {
            return this.providerDataAccess.GetProvidersLike(providerName);
        }

        public List<string> GetProviderLikeName(string providerName)
        {
            return providerDataAccess.GetProviderLikeName(providerName);
        }

        public List<string> GetAllProviderName()
        {
            return providerDataAccess.GetAllProviderName();
        }
        /// <summary>
        /// 查询所有供应商
        /// </summary>
        /// <returns>所有供应商</returns>
        public List<Provider> GetAllProvider()
        {
            return this.providerDataAccess.GetAllProvider();
        }
    }
}

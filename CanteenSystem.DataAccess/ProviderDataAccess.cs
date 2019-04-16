using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class ProviderDataAccess
    {
        ProviderDataContext providerDataContext;
        //构造方法
        public ProviderDataAccess()
        {
            this.providerDataContext = new Model.ProviderDataContext();
        }
        /// <summary>
        /// 添加供应商
        /// </summary>
        /// <param name="provider"></param>
        /// <returns>是否添加成功</returns>
        public bool AddProvider(Provider provider)
        {
            try
            {
                this.providerDataContext.Provider.InsertOnSubmit(provider);
                this.providerDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
                
            }
        }
        /// <summary>
        /// 通过供应商ID删除供应商
        /// </summary>
        /// <param name="providerID"></param>
        /// <returns>是否删除成功</returns>
        public bool DeleteProviderByID(string providerID)
        {
            try
            {
                Provider provider = this.providerDataContext.Provider.SingleOrDefault(o => o.ProviderID == providerID);
                this.providerDataContext.Provider.DeleteOnSubmit(provider);
                this.providerDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            
        }
        /// <summary>
        /// 更新供应商信息
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public bool UpdataProvider(Provider provider)
        {
            try
            {
                this.providerDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        /// <summary>
        /// 通过供应商ID查询供应商
        /// </summary>
        /// <param name="providerID">供应商ID</param>
        /// <returns>供应商</returns>
        public Provider GetProviderByID(string providerID)
        {
            Provider provider = new Provider();
            provider = this.providerDataContext.Provider.SingleOrDefault(o=>o.ProviderID==providerID);
            return provider;
        }
        /// <summary>
        /// 通过供应商名称查询供应商
        /// </summary>
        /// <param name="providerName">供应商名称</param>
        /// <returns>供应商</returns>
        public Provider GetProviderByName(string providerName)
        {
            Provider provider = new Provider();
            provider = this.providerDataContext.Provider.SingleOrDefault(o=>o.ProviderName== providerName);
            return provider;
        }
        /// <summary>
        /// 通过供应商名称的个别字进行模糊查询
        /// </summary>
        /// <param name="providerName">供应商名称中的某些字</param>
        /// <returns>包含指定字的供应商列表</returns>
        public List<Provider> GetProvidersLike(string providerName)
        {
            List<Provider> providerList = new List<Provider>();
            providerList=this.providerDataContext.Provider.Where(o=>o.ProviderName.Contains(providerName)).ToList();
            return providerList;
        }
        public List<string> GetProviderLikeName(string providerName)
        {
            var q = from p in providerDataContext.Provider where p.ProviderName.Contains(providerName) select p.ProviderName;
            return q.ToList();
        }

        public List<string> GetAllProviderName()
        {
            var q = from p in providerDataContext.Provider select p.ProviderName;
            return q.ToList();
        }
        /// <summary>
        /// 查询所有供应商
        /// </summary>
        /// <returns>所有供应商</returns>
        public List<Provider> GetAllProvider()
        {
            return this.providerDataContext.Provider.ToList();
        }
    }
}

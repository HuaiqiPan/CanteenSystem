using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.DataAccess
{
    public class PlanDataAccess
    {
        PlanDataContext planDataContext;
        //构造方法
        public PlanDataAccess()
        {
            this.planDataContext = new PlanDataContext();
        }


        //查询所有菜单
        public List<Plan> GetAllPlan()
        {
            return this.planDataContext.Plan.OrderBy(o=>o.Number).ToList();
        }

        public Plan GetPlanByID(string planID)
        {
            Plan plan = new Plan();
            plan = this.planDataContext.Plan.SingleOrDefault(o => o.PlanID == planID);
            return plan;
        }
        public bool AddPlan(Plan plan)
        {
            try
            {
                if (plan != null)
                {
                    this.planDataContext.Plan.InsertOnSubmit(plan);
                    this.planDataContext.SubmitChanges();
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

        public bool UpdataPlan(Plan plan)
        {
            try
            {
                planDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool DeletePlan(Plan plan)
        {
            try
            {
                if (plan != null)
                {
                    this.planDataContext.Plan.DeleteOnSubmit(plan);
                    this.planDataContext.SubmitChanges();
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
        public bool DeletePlanByID(string planID)
        {
            try
            {
                Plan plan = this.planDataContext.Plan.SingleOrDefault(o => o.PlanID == planID);
                if (plan != null)
                {
                    this.planDataContext.Plan.DeleteOnSubmit(plan);
                    this.planDataContext.SubmitChanges();
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

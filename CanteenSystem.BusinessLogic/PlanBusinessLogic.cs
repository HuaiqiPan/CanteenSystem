using CanteenSystem.DataAccess;
using CanteenSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenSystem.BusinessLogic
{
    public class PlanBusinessLogic
    {
        PlanDataAccess planDataAccess;
        public PlanBusinessLogic()
        {
            planDataAccess = new PlanDataAccess();
        }

        public List<Plan> GetAllPlan()
        {
            return planDataAccess.GetAllPlan();
        }

        public Plan GetPlanByID(string planID)
        {
            return planDataAccess.GetPlanByID(planID);
        }

        public bool AddPlan(Plan plan)
        {
            return planDataAccess.AddPlan(plan);
        }
        public bool UpdataPlan(Plan plan)
        {
            return planDataAccess.UpdataPlan(plan);
        }
        public bool DeletePlan(Plan plan)
        {
            return planDataAccess.DeletePlan(plan);
        }
        public bool DeletePlanByID(string planID)
        {
            return planDataAccess.DeletePlanByID(planID);
        }
        }
}

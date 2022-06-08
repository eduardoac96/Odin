using OdinDTO.PaymentPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinData.PaymentPlanDAL
{
    public interface IPaymentPlanDAL
    {
        List<DtoPaymentPlan> GetPaymentPlans();
    }
}

using OdinData.PaymentPlanDAL;
using OdinDTO.PaymentPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinService.PaymentPlanService
{
    public class PaymentPlanService : IPaymentPlanDAL
    {
        public IPaymentPlanDAL _paymentPlanDAL = null;

        public PaymentPlanService(IPaymentPlanDAL paymentPlanDAL)
        {
            _paymentPlanDAL = paymentPlanDAL;
        }
        public List<DtoPaymentPlan> GetPaymentPlans()
        {
            return _paymentPlanDAL.GetPaymentPlans();
        }
    }
}

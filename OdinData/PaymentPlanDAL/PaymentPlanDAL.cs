using OdinDTO.PaymentPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinData.PaymentPlanDAL
{
    public class PaymentPlanDAL : IPaymentPlanDAL
    {
        private IPaymentPlanDAL _paymentPlanDAL = null;

        
        public List<DtoPaymentPlan> GetPaymentPlans()
        {
            throw new NotImplementedException();
        }
    }
}

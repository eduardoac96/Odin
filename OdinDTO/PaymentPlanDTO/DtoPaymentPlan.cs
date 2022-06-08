using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinDTO.PaymentPlan
{
    public class DtoPaymentPlan
    {
        public int PaymentPlanID { get; set; }

        public string PaymentPlanTitle { get; set; }

        public int PaymentPlanFrecuencyID { get; set; }
        public string PaymentPlanFrecuency { get; set; }
        public string PaymentPlanDescription { get; set; }

        public double PaymentPlanCost { get; set; }

        public double Tax { get; set; }

        public int DiscountPercentage { get; set; }

        public double SubTotal { get; set; }

        public double Total { get; set; }
    }
}

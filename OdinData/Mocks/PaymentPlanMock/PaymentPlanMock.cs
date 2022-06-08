using OdinData.PaymentPlanDAL;
using OdinDTO.PaymentPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinData.Mocks.PaymentPlanMock
{
    public class PaymentPlanMock : IPaymentPlanDAL
    {
        public List<DtoPaymentPlan> GetPaymentPlans()
        {
            return new List<DtoPaymentPlan>()
            {
                new DtoPaymentPlan()
                {
                    PaymentPlanID = 1,
                    PaymentPlanTitle = "Plan Vivens Basico",
                    PaymentPlanDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla quam velit, vulputate eu pharetra nec, mattis ac neque. Duis vulputate commodo lectus, ac blandit elit tincidunt id. Sed rhoncus, tortor sed eleifend tristique, tortor mauris molestie elit, et lacinia ipsum quam nec dui. Quisque nec mauris sit amet elit iaculis pretium sit amet quis magna. Aenean velit odio, elementum in tempus ut, vehicula eu diam. ",
                    PaymentPlanCost = 442,
                    PaymentPlanFrecuencyID = 1,
                    PaymentPlanFrecuency = "Monthly",
                    Tax = 16,
                    DiscountPercentage = 0,

                },
                new DtoPaymentPlan()
                {
                    PaymentPlanID = 2,
                    PaymentPlanTitle = "Plan Vivens Basico",
                    PaymentPlanDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla quam velit, vulputate eu pharetra nec, mattis ac neque. Duis vulputate commodo lectus, ac blandit elit tincidunt id. Sed rhoncus, tortor sed eleifend tristique, tortor mauris molestie elit, et lacinia ipsum quam nec dui. Quisque nec mauris sit amet elit iaculis pretium sit amet quis magna. Aenean velit odio, elementum in tempus ut, vehicula eu diam. ",
                    PaymentPlanCost = 700,
                    PaymentPlanFrecuencyID = 1,
                    PaymentPlanFrecuency = "Monthly",
                    Tax = 16,
                    DiscountPercentage = 10,

                },

                new DtoPaymentPlan()
                {
                    PaymentPlanID = 3,
                    PaymentPlanTitle = "Plan Vivens Profesional",
                    PaymentPlanDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla quam velit, vulputate eu pharetra nec, mattis ac neque. Duis vulputate commodo lectus, ac blandit elit tincidunt id. Sed rhoncus, tortor sed eleifend tristique, tortor mauris molestie elit, et lacinia ipsum quam nec dui. Quisque nec mauris sit amet elit iaculis pretium sit amet quis magna. Aenean velit odio, elementum in tempus ut, vehicula eu diam. ",
                    PaymentPlanCost = 1200,
                    PaymentPlanFrecuencyID = 1,
                    PaymentPlanFrecuency = "Monthly",
                    Tax = 16,
                    DiscountPercentage = 10,

                },
            };
        }
    }
}

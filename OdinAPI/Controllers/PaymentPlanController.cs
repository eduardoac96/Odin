using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OdinData.PaymentPlanDAL;
using OdinService.PaymentPlanService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdinAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentPlanController : ControllerBase
    {
        private readonly ILogger<PaymentPlanController> _logger;
        private PaymentPlanService _paymentPlanService;

        public PaymentPlanController(ILogger<PaymentPlanController> logger, IPaymentPlanDAL paymentPlanDAL)
        {
            _logger = logger;
            _paymentPlanService = new PaymentPlanService(paymentPlanDAL);
        }

        [HttpGet]
        public List<OdinDTO.PaymentPlan.DtoPaymentPlan> GetPaymentPlans()
        {
            return _paymentPlanService.GetPaymentPlans();
        }
    }
}

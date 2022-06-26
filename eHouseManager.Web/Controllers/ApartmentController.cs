using eHouseManager.Common;
using eHouseManager.Services.Contracts;
using eHouseManager.Web.Attributes;
using eHouseManager.Web.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHouseManager.Web.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly IApartmentService _as;
        private readonly ITaxPaymentService _tps;
        public ApartmentController(IApartmentService @as, ITaxPaymentService tps)
        {
            _as = @as;
            _tps = tps;
        }

        [Authorize(Roles = Constants.ROLE_USER)]
        public IActionResult UserInfo()
        {
            var userId = int.Parse(this.HttpContext.Session.GetString(Constants.SESSION_ID_KEY));

            var apartmentInfo = _as.GetAllByUserId(userId).Select(x => x.GetUserApartmentModel());

            return View(apartmentInfo);
        }

        [HttpGet]
        [Authorize(Roles = Constants.ROLE_USER)]
        public FileResult Export(int id)
        {
            var lastTaxPayment = _tps.GetById(id);
            var sb = new StringBuilder();

            sb.AppendLine($"Year:, {lastTaxPayment.Year},");
            sb.AppendLine($"Month:, {lastTaxPayment.Month},");
            sb.AppendLine($"Paid On:, {lastTaxPayment.PaidOn},");
            sb.AppendLine($"Amount:, {lastTaxPayment.Amount}");

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/csv", "Payment.csv");
        }

        [Authorize(Roles = Constants.ROLE_EMPLOYEE)]
        public IActionResult Index()
        {

            var apartmentInfo = _as.GetAll().Select(x => x.GetAllApartmentModel());

            return View(apartmentInfo);
        }

        [HttpPost]
        [Authorize(Roles = Constants.ROLE_EMPLOYEE)]
        public IActionResult Delete(int id)
        {
            _as.Delete(id);
            var apartmentInfo = _as.GetAll();

            return View(apartmentInfo);
        }
    }
}

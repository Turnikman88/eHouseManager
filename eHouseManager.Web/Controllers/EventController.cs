using eHouseManager.Common;
using eHouseManager.Services.Contracts;
using eHouseManager.Web.Attributes;
using eHouseManager.Web.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Web.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _es;

        public EventController(IEventService es)
        {
            _es = es;
        }

        [Authorize(Roles = Constants.ROLE_USER)]
        public IActionResult UserInfo()
        {
            var userId = int.Parse(this.HttpContext.Session.GetString(Constants.SESSION_ID_KEY));

            var result = _es.GetAllByUserId(userId).Select(x => x.GetEventModel());

            return View(result);
        }


    }
}

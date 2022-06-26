using eHouseManager.Common;
using eHouseManager.Services.Contracts;
using eHouseManager.Web.Attributes;
using eHouseManager.Web.Mappers;
using eHouseManager.Web.Models;
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

        [Authorize(Roles = Constants.ROLE_EMPLOYEE)]
        public IActionResult Index()
        {

            var apartmentInfo = _es.GetAll().Select(x => x.GetEventModel());

            return View(apartmentInfo);
        }

        [Authorize(Roles = Constants.ROLE_EMPLOYEE)]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = Constants.ROLE_EMPLOYEE)]
        [HttpPost]
        public IActionResult Create(EventViewModel model)
        {
            _es.Post(model.GetEventDTO());
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = Constants.ROLE_EMPLOYEE)]
        public IActionResult Update(int id)
        {
            var model = _es.GetById(id);
            return View(model.GetEventModel());
        }

        [Authorize(Roles = Constants.ROLE_EMPLOYEE)]
        [HttpPost]
        public IActionResult Update(int id, EventViewModel model)
        {
            _es.Update(id, model.GetEventDTO());
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = Constants.ROLE_EMPLOYEE)]
        public IActionResult Delete(int id)
        {
            _es.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}

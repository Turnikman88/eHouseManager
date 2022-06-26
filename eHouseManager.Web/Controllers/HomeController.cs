using eHouseManager.Common;
using eHouseManager.Services.Contracts;
using eHouseManager.Services.Helpers;
using eHouseManager.Services.Services;
using eHouseManager.Web.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace eHouseManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApartmentService _as;
        private readonly IUserService _us;

        public HomeController(IApartmentService @as, IUserService us)
        {
            _as = @as;
            _us = us;
        }

        public IActionResult Index()
        {
            var indexview = new IndexViewModel();
            indexview.UserCount = _us.GetCount();
            indexview.ApartmentCount = _as.GetCount();

            return View(indexview);
        }

        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult Error()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
            var imageLink = $"{Constants.DOMAIN_NAME}/images/";

            if (exception != null)
            {
                switch (exception)
                {
                    case AppException e:
                        // custom application error
                        HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                        imageLink += "400.png";
                        break;
                    case UnauthorizedAppException e:
                        HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        imageLink += "401.png";
                        break;
                    case KeyNotFoundException e:
                        // not found error
                        HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                        imageLink += "404.png";
                        break;
                    default:
                        // unhandled error
                        imageLink += "500.png";
                        HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }
            }
            else
            {
                imageLink += "404.png";
            }

            var statuscode = HttpContext.Response.StatusCode;
            return View(new ErrorViewModel { StatusCode = statuscode, Message = exception?.Message ?? "Wrong Address!", ImageLink = imageLink });
        }
    }
}

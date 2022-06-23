using eHouseManager.Common;
using eHouseManager.Services.Contracts;
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
    public class AuthController : Controller
    {
        private readonly IAuthService _auth;
        private readonly IUserService _us;
        public AuthController(IAuthService auth, IUserService us)
        {
            _auth = auth;
            _us = us;
        }
        public IActionResult Login()
        {
            var loginViewModel = new LoginViewModel();

            return this.View(loginViewModel);
        }

        //POST: /auth/login
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (!_auth.IsExistingEmail(loginViewModel.Email))
            {
                this.ModelState.AddModelError("Email", "User with this email address doesn't exists.");
                return this.View(loginViewModel);
            }

            if (!_auth.IsPasswordValid(loginViewModel.Email, loginViewModel.Password))
            {
                this.ModelState.AddModelError("Password", "Wrong Password!");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(loginViewModel);
            }

            var credentials = $"{loginViewModel.Email} {loginViewModel.Password}";

            var user = _auth.FindUser(loginViewModel.Email, loginViewModel.Password);
            if (user is null)
            {
                this.ModelState.AddModelError("Username", "Invalid input data");
                return this.View(loginViewModel);
            }
            else
            {
                this.HttpContext.Session.SetString(Constants.SESSION_AUTH_KEY, credentials);
                this.HttpContext.Session.SetString(Constants.SESSION_ROLE_KEY, user.Role);
                this.HttpContext.Session.SetString(Constants.SESSION_ID_KEY, user.UserId.ToString());

                return this.RedirectToAction("Index", "Home");
            }
        }

        //GET: /auth/logout
        public IActionResult Logout()
        {
            this.HttpContext.Session.Remove(Constants.SESSION_AUTH_KEY);

            return this.RedirectToAction("index", "home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            var model = new UserViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(UserViewModel model)
        {
            if ( _auth.IsExistingEmail(model.Email))
            {
                this.ModelState.AddModelError("Email", "User with this email address already exists.");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            _us.Post(model.GetDTOFromModel());

            return this.Redirect(nameof(Login));
        }

        public ActionResult Settings()
        {
            var userId = int.Parse(this.HttpContext.Session.GetString(Constants.SESSION_ID_KEY));

            var user = _us.GetById(userId);

            return View(user.GetSettingsModel());
        }

        //POST: /auth/settings
        [HttpPost]
        public IActionResult Settings(SettingsViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var userId = int.Parse(this.HttpContext.Session.GetString(Constants.SESSION_ID_KEY));

            _us.Update(userId, model.GetDTOFromSettingsModel());

            return this.RedirectToAction("Index", "Home");
        }
    }
}

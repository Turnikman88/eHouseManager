using eHouseManager.Common;
using eHouseManager.Services.Contracts;
using eHouseManager.Services.Helpers;
using eHouseManager.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Web.Attributes
{
    public class Authorize : ActionFilterAttribute, IAuthorizationFilter
    {
        public string Roles { get; set; }
        public string QueryId { get; set; }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.Keys.Contains(Constants.SESSION_AUTH_KEY))
            {
                var credentials = context.HttpContext.Session.GetString(Constants.SESSION_AUTH_KEY);
                var authService = context.HttpContext.RequestServices.GetService(typeof(IAuthService)) as AuthService;

                var splitted = credentials.Split();
                var email = splitted[0];
                var password = splitted[1];

                var user = authService.FindUser(email, password);
                if (user == null || Roles != user.Role && Roles != null)
                {
                    throw new UnauthorizedAppException(Constants.NOT_AUTHORIZED);
                }
                if (QueryId != null && context.HttpContext.Request.Query.ContainsKey(QueryId))
                {
                    var queryUserId = context.HttpContext.Request.Query[QueryId];
                    if (queryUserId != user.Id)
                    {
                        throw new UnauthorizedAppException(Constants.NOT_AUTHORIZED);
                    }
                }
            }
            else
            {
                throw new UnauthorizedAppException(Constants.NOT_LOGGED);
            }
        }
    }
}

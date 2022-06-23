using eHouseManager.Common;
using eHouseManager.Services.DTOs;
using eHouseManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Web.Mappers
{
    public static class UserMapperExtension
    {
        public static UserDTO GetDTOFromModel(this UserViewModel model)
        {
            return new UserDTO
            {
                Email = model.Email,
                IsActive = true,
                Password = model.Password,
                Phone = model.Phone,
                Role  = Constants.ROLE_USER
            };
        }
    }
}

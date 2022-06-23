using eHouseManager.Data.DatabaseModels;
using eHouseManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.DTOMappers
{
    public static class UserDTOMapper
    {
        public static UserDTO ToDTO(this User model)
        {
            return new UserDTO
            {
                Email = model.Email,
                Role = model.Role,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IsActive = model.IsActive,
                ModifiedBy = model.ModifiedBy,
                Password = model.Password,
                Phone = model.Phone,
                UserId = model.UserID,
                UserTypeCD = model.UserTypeCD
            };
        }

        public static User ToEntity(this UserDTO model)
        {
            return new User
            {
                Email = model.Email,
                Role = model.Role,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IsActive = model.IsActive,
                ModifiedBy = model.ModifiedBy,
                Password = model.Password,
                Phone = model.Phone,
                UserID = model.UserId,
                UserTypeCD = model.UserTypeCD
            };
        }
    }
}

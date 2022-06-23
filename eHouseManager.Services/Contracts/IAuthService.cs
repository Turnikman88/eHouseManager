using eHouseManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.Contracts
{
    public interface IAuthService
    {
        bool IsExistingEmail(string email);

        bool IsPasswordValid(string email, string password);

        UserDTO FindUser(string email, string password);
    }
}

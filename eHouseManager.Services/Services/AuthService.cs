using eHouseManager.Data;
using eHouseManager.Services.Contracts;
using eHouseManager.Services.DTOMappers;
using eHouseManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eHouseManager.Services.Services
{
    public class AuthService : IAuthService
    {
        private readonly eHouseManagerDbContext _db;

        public AuthService(eHouseManagerDbContext db)
        {
            _db = db;
        }

        public UserDTO FindUser(string email, string password)
        {
            return _db.Users.FirstOrDefault(x => x.Email.ToLower() == email.ToLower()
                                            && x.Password.ToLower() == password.ToLower())
                                            .ToDTO();
        }

        public bool IsExistingEmail(string email)
        {
            return _db.Users.Any(x => x.Email.ToLower() == email.ToLower());
        }

        public bool IsPasswordValid(string email, string password)
        {
            return _db.Users.Any(x => x.Email.ToLower() == email.ToLower()
            &&x.Password.ToLower() == password.ToLower());
        }
    }
}

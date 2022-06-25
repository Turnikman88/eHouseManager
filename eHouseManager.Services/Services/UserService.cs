using eHouseManager.Common;
using eHouseManager.Data;
using eHouseManager.Data.DatabaseModels;
using eHouseManager.Services.Contracts;
using eHouseManager.Services.DTOMappers;
using eHouseManager.Services.DTOs;
using eHouseManager.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eHouseManager.Services.Services
{
    public class UserService : IUserService
    {
        private readonly eHouseManagerDbContext _db;
        public UserService(eHouseManagerDbContext db)
        {
            _db = db;
        }
        public UserDTO Delete(int id)
        {
            var userToDelete = _db.Users.FirstOrDefault(x => x.Id == id) ?? throw new AppException(Constants.ENTITY_NOT_FOUND);
            _db.Users.Remove(userToDelete);
            _db.SaveChanges();
            return userToDelete.ToDTO();
        }

        public IEnumerable<UserDTO> GetAll()
        {
            return _db.Users.Select(x => x.ToDTO());
        }

        public UserDTO GetById(int id)
        {
            return _db.Users.FirstOrDefault(x => x.Id == id)?.ToDTO() ?? throw new AppException(Constants.ENTITY_NOT_FOUND);
        }

        public int GetCount()
        {
            return _db.Users.Count();
        }

        public UserDTO Post(UserDTO obj)
        {
            var model = obj.ToEntity();

            _db.Add(model);
            _db.SaveChanges();

            model = _db.Users.FirstOrDefault(x => x.Id == model.Id);

            return model.ToDTO();
        }

        public UserDTO Update(int id, UserDTO obj)
        {
            var modelToUpdate = _db.Users.FirstOrDefault(x => x.Id == id);
            PropertyCopier<UserDTO, User>.Copy(obj, modelToUpdate);

            _db.SaveChanges();

            return modelToUpdate.ToDTO();
        }
    }
}

using eHouseManager.Common;
using eHouseManager.Data;
using eHouseManager.Data.DatabaseModels;
using eHouseManager.Services.Contracts;
using eHouseManager.Services.DTOMappers;
using eHouseManager.Services.DTOs;
using eHouseManager.Services.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eHouseManager.Services.Services
{
    public class ApartmentService : IApartmentService
    {
        private readonly eHouseManagerDbContext _db;
        public ApartmentService(eHouseManagerDbContext db)
        {
            _db = db;
        }

        public ApartmentDTO Delete(int id)
        {
            var objToDelete = _db.Apartments.FirstOrDefault(x => x.ApartmentID == id) ?? throw new AppException(Constants.ENTITY_NOT_FOUND);
            _db.Apartments.Remove(objToDelete);
            _db.SaveChanges();
            return objToDelete.ToDTO();
        }

        public IEnumerable<ApartmentDTO> GetAll()
        {
            return _db.Apartments.Select(x => x.ToDTO());
        }

        public IEnumerable<ApartmentDTO> GetAllByUserId(int id)
        {
            return _db.UserApartmentAccesses.Where(x => x.UserID == id)
                .Include(x => x.Apartment)
                .Select(x => x.Apartment.ToDTO());
        }

        public ApartmentDTO GetById(int id)
        {
            return _db.Apartments.FirstOrDefault(x => x.ApartmentID == id)?.ToDTO() ?? throw new AppException(Constants.ENTITY_NOT_FOUND);
        }

        public int GetCount()
        {
            return _db.Apartments.Count();
        }

        public ApartmentDTO Post(ApartmentDTO obj)
        {
            var model = obj.ToEntity();

            _db.Add(model);
            _db.SaveChanges();

            model = _db.Apartments.FirstOrDefault(x => x.ApartmentID == model.ApartmentID);

            return model.ToDTO();
        }

        public ApartmentDTO Update(int id, ApartmentDTO obj)
        {
            var modelToUpdate = _db.Apartments.FirstOrDefault(x => x.ApartmentID == id);

            PropertyCopier<ApartmentDTO, Apartment>.Copy(obj, modelToUpdate);

            _db.SaveChanges();

            return modelToUpdate.ToDTO();
        }
    }
}

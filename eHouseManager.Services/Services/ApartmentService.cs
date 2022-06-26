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
        private readonly ITaxPaymentService _tps;
        public ApartmentService(eHouseManagerDbContext db, ITaxPaymentService tps)
        {
            _db = db;
            _tps = tps;
        }

        public ApartmentDTO Delete(int id)
        {
            var objToDelete = _db.Apartments.FirstOrDefault(x => x.Id == id) ?? throw new AppException(Constants.ENTITY_NOT_FOUND);
            _db.Apartments.Remove(objToDelete);
            _db.SaveChanges();
            return objToDelete.ToDTO();
        }

        public IEnumerable<ApartmentDTO> GetAll()
        {
            return _db.Apartments.OrderBy(x => x.Area).ThenBy(x => x.AreTaxesPaid).Select(x => x.ToDTO());
        }

        public IEnumerable<ApartmentDTO> GetAllByUserId(int id)
        {
            var a = _db.UserApartmentAccesses.Where(x => x.UserId == id)
                .Include(x => x.Apartment).ThenInclude(x => x.TaxPayments)
                .Select(x => x.Apartment.ToDTO());
            return a;
        }

        public ApartmentDTO GetById(int id)
        {
            return _db.Apartments.FirstOrDefault(x => x.Id == id)?.ToDTO() ?? throw new AppException(Constants.ENTITY_NOT_FOUND);
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

            var userId = _db.Users.Where(x => x.UcnNumber == obj.UcnNumber).Select(x => x.Id).FirstOrDefault();
            if (userId != 0)
            {
                _db.UserApartmentAccesses.Add(new UserApartmentAccess { UserId = userId, ApartmentId = model.Id });
                _db.SaveChanges();
            }

            model = _db.Apartments.FirstOrDefault(x => x.Id == model.Id);
            return model.ToDTO();
        }

        public ApartmentDTO Update(int id, ApartmentDTO obj)
        {
            var modelToUpdate = _db.Apartments.FirstOrDefault(x => x.Id == id);

            PropertyCopier<ApartmentDTO, Apartment>.Copy(obj, modelToUpdate);

            _db.SaveChanges();

            return modelToUpdate.ToDTO();
        }
    }
}

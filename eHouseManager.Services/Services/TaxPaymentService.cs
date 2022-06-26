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
    public class TaxPaymentService : ITaxPaymentService
    {
        private readonly eHouseManagerDbContext _db;

        public TaxPaymentService(eHouseManagerDbContext db)
        {
            _db = db;
        }

        public TaxPaymentDTO Delete(int id)
        {
            var objToDelete = _db.TaxPayments.FirstOrDefault(x => x.Id == id) ?? throw new AppException(Constants.ENTITY_NOT_FOUND);
            _db.TaxPayments.Remove(objToDelete);
            _db.SaveChanges();

            return objToDelete.ToDTO();
        }

        public IEnumerable<TaxPaymentDTO> GetAll()
        {
            return _db.TaxPayments.Select(x => x.ToDTO());
        }

        public IEnumerable<TaxPaymentDTO> GetAllByApartmentId(int apartmentId)
        {
            return _db.TaxPayments.Where(x => x.ApartmentId == apartmentId).Select(x => x.ToDTO());
        }

        public TaxPaymentDTO GetById(int id)
        {
            return _db.TaxPayments.FirstOrDefault(x => x.Id == id).ToDTO();
        }

        public TaxPaymentDTO Post(TaxPaymentDTO obj)
        {
            var model = obj.ToEntity();

            _db.Add(model);
            _db.SaveChanges();

            model = _db.TaxPayments.FirstOrDefault(x => x.Id == model.Id);

            return model.ToDTO();
        }

        public TaxPaymentDTO Update(int id, TaxPaymentDTO obj)
        {
            var modelToUpdate = _db.TaxPayments.FirstOrDefault(x => x.Id == id);

            PropertyCopier<TaxPaymentDTO, TaxPayment>.Copy(obj, modelToUpdate);

            modelToUpdate.ModifiedOn = DateTime.UtcNow;

            _db.SaveChanges();

            return modelToUpdate.ToDTO();
        }
    }
}

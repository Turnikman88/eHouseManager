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
    public class ObligationService : IObligationService
    {
        private readonly eHouseManagerDbContext _db;

        public ObligationService(eHouseManagerDbContext db)
        {
            _db = db;
        }

        public ObligationDTO Delete(int id)
        {
            var objToDelete = _db.Obligations.FirstOrDefault(x => x.Id == id) ?? throw new AppException(Constants.ENTITY_NOT_FOUND);
            _db.Obligations.Remove(objToDelete);
            _db.SaveChanges();

            return objToDelete.ToDTO();
        }

        public IEnumerable<ObligationDTO> GetAll()
        {
            return _db.Obligations.Select(x => x.ToDTO());
        }

        public ObligationDTO GetById(int id)
        {
            return _db.Obligations.FirstOrDefault(x => x.Id == id).ToDTO();
        }

        public ObligationDTO Post(ObligationDTO obj)
        {
            var model = obj.ToEntity();

            _db.Add(model);
            _db.SaveChanges();

            model = _db.Obligations.FirstOrDefault(x => x.Id == model.Id);

            return model.ToDTO();
        }

        public ObligationDTO Update(int id, ObligationDTO obj)
        {
            var modelToUpdate = _db.Obligations.FirstOrDefault(x => x.Id == id);

            PropertyCopier<ObligationDTO, Obligation>.Copy(obj, modelToUpdate);

            _db.SaveChanges();

            return modelToUpdate.ToDTO();
        }
    }
}

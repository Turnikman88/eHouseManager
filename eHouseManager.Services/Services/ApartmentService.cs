﻿using eHouseManager.Data;
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
    public class ApartmentService : IApartment
    {
        private readonly eHouseManagerDbContext _db;
        public ApartmentService(eHouseManagerDbContext db)
        {
            _db = db;
        }

        public ApartmentDTO Delete(int id)
        {
            var objToDelete = _db.Apartments.FirstOrDefault(x => x.ApartmentID == id) ?? throw new AppException();
            _db.Apartments.Remove(objToDelete);
            _db.SaveChanges();
            return objToDelete.ToDTO();
        }

        public IEnumerable<ApartmentDTO> GetAll()
        {
            return _db.Apartments.Select(x => x.ToDTO());
        }

        public ApartmentDTO GetById(int id)
        {
            return _db.Apartments.FirstOrDefault(x => x.ApartmentID == id).ToDTO();
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

            modelToUpdate.ApartmentNumber = obj.ApartmentNumber;
            modelToUpdate.Area = obj.Area;
            modelToUpdate.Inhabitants = obj.Inhabitants;
            modelToUpdate.Owner = obj.Owner;
            modelToUpdate.ModifiedBy = obj.ModifiedBy;

            _db.SaveChanges();

            return modelToUpdate.ToDTO();
        }
    }
}

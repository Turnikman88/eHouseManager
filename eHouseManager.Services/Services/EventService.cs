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
    public class EventService : IEventService
    {
        private readonly eHouseManagerDbContext _db;

        public EventService(eHouseManagerDbContext db)
        {
            _db = db;
        }

        public EventDTO Delete(int id)
        {
            var objToDelete = _db.Events.FirstOrDefault(x => x.Id == id) ?? throw new AppException(Constants.ENTITY_NOT_FOUND);
            _db.Events.Remove(objToDelete);
            _db.SaveChanges();

            return objToDelete.ToDTO();
        }

        public IEnumerable<EventDTO> GetAll()
        {
            return _db.Events.Select(x => x.ToDTO());
        }

        public IEnumerable<EventDTO> GetAllByUserId(int id)
        {
            var a = _db.UserEventAccesses.Where(x => x.UserId == id)
               .Include(x => x.Event)
               .Select(x => x.Event.ToDTO());
            return a;
        }

        public EventDTO GetById(int id)
        {
            return _db.Events.FirstOrDefault(x => x.Id == id).ToDTO();
        }

        public EventDTO Post(EventDTO obj)
        {
            var model = obj.ToEntity();

            _db.Add(model);
            _db.SaveChanges();

            model = _db.Events.FirstOrDefault(x => x.Id == model.Id);

            return model.ToDTO();
        }

        public EventDTO Update(int id, EventDTO obj)
        {
            var modelToUpdate = _db.Events.FirstOrDefault(x => x.Id == id);

            PropertyCopier<EventDTO, Event>.Copy(obj, modelToUpdate);

            _db.SaveChanges();

            return modelToUpdate.ToDTO();
        }
    }
}

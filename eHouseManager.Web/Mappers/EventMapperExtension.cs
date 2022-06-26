using eHouseManager.Services.DTOs;
using eHouseManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Web.Mappers
{
    public static class EventMapperExtension
    {
        public static EventViewModel GetEventModel(this EventDTO model)
        {
            return new EventViewModel
            {
                Id = model.Id,
                EventDateTime = model.EventDateTime,
                Status = model.Status,
                Title = model.Title,
                UcnNumber = model.UcnNumber
            };
        }

        public static EventDTO GetEventDTO(this EventViewModel model)
        {
            return new EventDTO
            {
                Id = model.Id,
                EventDateTime = model.EventDateTime,
                Status = model.Status,
                Title = model.Title,
                UcnNumber = model.UcnNumber
            };
        }
    }
}

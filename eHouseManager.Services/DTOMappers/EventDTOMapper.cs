using eHouseManager.Data.DatabaseModels;
using eHouseManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.DTOMappers
{
    public static class EventDTOMapper
    {
        public static EventDTO ToDTO(this Event model)
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

        public static Event ToEntity(this EventDTO model)
        {
            return new Event
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

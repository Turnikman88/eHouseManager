using eHouseManager.Data.DatabaseModels;
using eHouseManager.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.DTOMappers
{
    public static class ObligationDTOMapper
    {
        public static ObligationDTO ToDTO(this Obligation model)
        {
            return new ObligationDTO
            {
                Id = model.Id,
                Description = model.Description,
                DueDate = model.DueDate
            };
        }

        public static Obligation ToEntity(this ObligationDTO model)
        {
            return new Obligation
            {
                Id = model.Id,
                Description = model.Description,
                DueDate = model.DueDate
            };
        }
    }
}

using eHouseManager.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHouseManager.Data.DatabaseModels
{
    public class TaxType : BaseModel<int>
    {
        public string TaxCD { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public string Calculation { get; set; }
        public bool IsActive { get; set; }
    }
}

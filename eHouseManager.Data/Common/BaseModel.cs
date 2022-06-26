using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eHouseManager.Data.Common
{
    public class BaseModel<TKey> : IBaseModel
    {
        [Key]
        public TKey Id { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}

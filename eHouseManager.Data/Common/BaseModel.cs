using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eHouseManager.Data.Common
{
    public class BaseModel<TKey> : IBaseModel
    {
        [Key]
        public TKey Id { get; set; }

        [Column("ModifiedOn18118025")]
        public DateTime ModifiedOn { get; set; }
    }
}

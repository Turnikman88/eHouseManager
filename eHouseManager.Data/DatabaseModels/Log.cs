using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eHouseManager.Data.DatabaseModels
{
    [Table("log_18118025")]
    public class Log 
    {
        [Key]
        public int Id { get; set; }
        public string TableName { get; set; }
        public string OperationType { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}

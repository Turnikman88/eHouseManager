using System;

namespace eHouseManager.Data.Common
{
    public interface IBaseModel
    {
        string ModifiedBy { get; set; }
        DateTime ModifiedOn { get; set; }
    }
}
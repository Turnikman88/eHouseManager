using System;

namespace eHouseManager.Data.Common
{
    public interface IBaseModel
    {
        DateTime ModifiedOn { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eHouseManager.Services.Contracts
{
    public interface ICrud<T> where T : class 
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Post(T obj);
        T Update(int id, T obj);
        T Delete(int id);
    }
}

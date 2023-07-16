using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IGenericRepository<T>
        where T : BaseEntity, new()
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<bool> DeleteById(Guid id);
        Task<bool> Update(T footballer);
        Task<Guid> Add(T footballer);
    }
}

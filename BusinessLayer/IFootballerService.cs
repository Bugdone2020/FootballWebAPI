using DataAccessLayer;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IFootballerService
    {
        Task<IEnumerable<Footballer>> GetAllFootballer();
        Task<Footballer> GetFootballerById(Guid id);
        Task<bool> DeleteFootballerById(Guid id);
        Task<bool> UpdateFootballer(Footballer footballer);
        Task<Guid> AddFootballer(Footballer footballer);
    }
}

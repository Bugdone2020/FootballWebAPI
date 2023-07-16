using DataAccessLayer;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FootballerService : IFootballerService
    {
        private readonly IGenericRepository<Footballer> _footballerRepository;

        public FootballerService(IGenericRepository<Footballer> footballerRepository)
        {
            _footballerRepository = footballerRepository;
        }
        public async Task<Guid> AddFootballer(Footballer footballer)
        {
            ValidateFootballerState(footballer);

            return await _footballerRepository.Add(footballer);
        }

        public async Task<bool> DeleteFootballerById(Guid id)
        {
            return await _footballerRepository.DeleteById(id);
        }

        public async Task<IEnumerable<Footballer>> GetAllFootballer()
        {
            return await _footballerRepository.GetAll();
        }

        public async Task<Footballer> GetFootballerById(Guid id)
        {
            return await _footballerRepository.GetById(id);
        }

        public async Task<bool> UpdateFootballer(Footballer footballer)
        {
            ValidateFootballerState(footballer);

            return await _footballerRepository.Update(footballer);
        }

        private void ValidateFootballerState(Footballer footballer)
        {
            if (footballer.Number < 0 || footballer.Number > 99)
            {
                throw new ArgumentException("Invalid footballer's number");
            }
        }
    }
}

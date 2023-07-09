using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FootballerService : IFootballerService
    {
        private readonly IFootballerRepository _footballerRepository;

        public FootballerService(IFootballerRepository footballerRepository)
        {
            _footballerRepository = footballerRepository;
        }
        public Guid AddFootballer(Footballer footballer)
        {
            ValidateFootballerState(footballer);

            return _footballerRepository.Add(footballer);
        }

        public bool DeleteFootballerById(Guid id)
        {
            return _footballerRepository.DeleteById(id);
        }

        public IEnumerable<Footballer> GetAllFootballer()
        {
            return _footballerRepository.GetAll();
        }

        public Footballer GetFootballerById(Guid id)
        {
            return _footballerRepository.GetById(id);
        }

        public bool UpdateFootballer(Footballer footballer)
        {
            ValidateFootballerState(footballer);

            return _footballerRepository.Update(footballer);
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

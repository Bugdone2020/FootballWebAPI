using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FootballerRepository : IFootballerRepository
    {
        private readonly EFCoreDbContext _dbContext;
        public FootballerRepository(EFCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Guid Add(Footballer footballer)
        {
            footballer.Id = Guid.NewGuid();
            _dbContext.Footballers.Add(footballer);
            _dbContext.SaveChanges();
            return footballer.Id;
        }

        public bool DeleteById(Guid id)
        {
            var footballer = new Footballer { Id = id };
            _dbContext.Entry(footballer).State = EntityState.Deleted;

            return _dbContext.SaveChanges() != 0;
        }

        public IEnumerable<Footballer> GetAll()
        {
            return _dbContext.Footballers.ToList();
        }

        public Footballer GetById(Guid id)
        {
            return _dbContext.Footballers.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool Update(Footballer footballer)
        {
            _dbContext.Entry(footballer).State = EntityState.Modified;

            return _dbContext.SaveChanges() != 0;
        }
    }
}

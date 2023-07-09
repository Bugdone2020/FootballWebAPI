using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IFootballerRepository
    {
        IEnumerable<Footballer> GetAll();
        Footballer GetById(Guid id);
        bool DeleteById(Guid id);
        bool Update(Footballer footballer);
        Guid Add(Footballer footballer);
    }
}

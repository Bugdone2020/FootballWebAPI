using DataAccessLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IFootballerService
    {
        IEnumerable<Footballer> GetAllFootballer();
        Footballer GetFootballerById(Guid id);
        bool DeleteFootballerById(Guid id);
        bool UpdateFootballer(Footballer footballer);
        Guid AddFootballer(Footballer footballer);
    }
}

using DI.interfaces;
using DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Services
{
    public class AService : IService<A>
    {
        private readonly AppDbContext _appdb;
        public AService(AppDbContext appdb)
        {
            _appdb = appdb;  
        }
        public List<A> GetAll()
        {
           return _appdb.As.ToList();
        }
    }
}
